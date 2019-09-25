/*
 * @lc app=leetcode id=38 lang=java
 *
 * [38] Count and Say
 */
class Solution {
    public String countAndSay(int n) {
        String prevPerson = "1";
        for (int i = 1; i < n; i++) {
            char num = prevPerson.charAt(0);
            Integer count = 1;
            StringBuilder nextPerson = new StringBuilder(1024);
            for (int j = 1; j < prevPerson.length(); j++) {
                if (prevPerson.charAt(j) == num)
                    count++;
                else {
                    nextPerson.append(count);
                    nextPerson.append(num);
                    num = prevPerson.charAt(j);
                    count = 1;
                }
            }
            nextPerson.append(count);
            nextPerson.append(num);
            prevPerson = nextPerson.toString();
        }
        return prevPerson;
    }
}
