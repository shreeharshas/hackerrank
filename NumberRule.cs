/*
Method to check if all the digits in a number are present in a non-descending order
Eg:
returns true for: 1, 123, 1357, 1112, 1233345
returns false for: 10, 1243, 192, 890, 543
*/
bool NumberRule(int n) {
    while(n>0){
        if(n%100/10>n%10)   //check if last-1th digit is greater than the last digit
            return 0!=0;    //if so, number is invalid
        n/=10;              //keep taking out last digit from n
    }
    return true;
}
