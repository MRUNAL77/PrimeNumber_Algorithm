# PrimeNumber_Algorithm
Implemented two types of algorithms in a project and their timings for a bigger number.

# Algorithm 1
for(int i; i<=n; i++)<br/>
&nbsp;&nbsp;if (n% 2== 0)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;return false;<br/>
return true;<br/>

# Algorithm 2
if (n<=1) return false;<br/>
if (n==2) return true;<br/>
if (n%2==0) return false;<br/>
int m=Math.sqrt(n);<br/>

for (int i=3; i<=m; i+=2)<br/>
&nbsp;&nbsp;if (n%i==0)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;return false;<br/>
return true;<br/>
