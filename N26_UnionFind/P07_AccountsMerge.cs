// Accounts Merge
// ==============
//
// You are given a 2D array, `accounts`, where each row, `accounts[i]`, is an array of strings, such that the first
// element, `accounts[i][0]`, is a name, while the remaining elements are emails associated with that account. Your task
// is to determine if two accounts belong to the same person by checking if both accounts have the same name and at
// least one common email address.
//
// If two accounts have the same name, they might belong to different people since people can have the same name.
// However, all accounts that belong to one person will have the same name. This implies that a single person can hold
// multiple accounts.
//
// The output should be a 2D array in which the first element of each row is the name, and the rest of the elements are
// the merged list of that user's email addresses in sorted order. There should be one row for each distinct user, and
// for each user, each email address should be listed only once.
//
// > Note: Please use a `sort` function that sorts the email addresses based on the ASCII value of each character.
//
// Constraints:
//
// - 1 ≤ `accounts.length` ≤ 100
// - 2 ≤ `accounts[i].length` ≤ 10
// - 1 ≤ `accounts[i][j].length` ≤ 30
// - Because `accounts[i][0]` is the name of any person, it should contain only English letters.
// - For j > 0, `accounts[i][j]` should be a valid email.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P07_AccountsMerge;

public class Solution
{
    // Time complexity: O(a*e*loge), Space complexity: O(a*e) where a = number of accounts, e = max emails in any account.
    public static List<List<string>> AccountsMerge(List<List<string>> accounts)
    {
        var emailAccounts = new Dictionary<string, int>();

        var accountParents = new Dictionary<int, int>();
        var accountRanks = new Dictionary<int, int>();

        for (int id = 0; id != accounts.Count; id++)
        {
            accountParents[id] = id;
            accountRanks[id] = 1;

            foreach (string email in accounts[id].Skip(1))
            {
                if (!emailAccounts.TryGetValue(email, out int previousId))
                {
                    emailAccounts[email] = id;
                }
                else if (accounts[id][0] != accounts[previousId][0])
                {
                    return new List<List<string>>();
                }
                else
                {
                    Union(id, previousId);
                }
            }
        }

        var mergedAccounts = new Dictionary<int, List<string>>();
        foreach ((string email, int id) in emailAccounts)
        {
            int parentId = Find(id);
            mergedAccounts.TryAdd(parentId, new List<string>());
            mergedAccounts[parentId].Add(email);
        }

        var result = new List<List<string>>();
        foreach ((int id, List<string> emails) in mergedAccounts)
        {
            var account = new List<string> { accounts[id][0] };
            emails.Sort();
            account.AddRange(emails);
            result.Add(account);
        }

        return result;

        void Union(int id1, int id2)
        {
            int p1 = Find(id1);
            int p2 = Find(id2);

            if (accountRanks[p1] == accountRanks[p2]) { accountRanks[p1]++; }
            if (accountRanks[p1] >= accountRanks[p2]) { accountParents[p2] = p1; }
            else { accountParents[p2] = p1; }
        }

        int Find(int id)
        {
            if (accountParents[id] != id) { accountParents[id] = Find(accountParents[id]); }
            return accountParents[id];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [
                ["A", "a1", "a2"],
                ["A", "a3", "a4"],
                ["A", "a5", "a6"],
                ["A", "a7", "a1"],
                ["A", "a8", "a3"],
                ["A", "a7", "a8"],
                ["B", "b1", "b2"],
            ],
            [
                ["A", "a1", "a2", "a3", "a4", "a7", "a8"],
                ["A", "a5", "a6"],
                ["B", "b1", "b2"],
            ]
        );

        Run(
            [
                ["A","a3"],
                ["A","a4","a3"],
                ["A","a3","a2","a1"],
            ],
            [
                ["A","a1","a2","a3","a4"],
            ]
        );
    }

    private static void Run(List<List<string>> accounts, List<List<string>> expectedResult)
    {
        List<List<string>> result = Solution.AccountsMerge(accounts);
        Utilities.PrintSolution(accounts, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
