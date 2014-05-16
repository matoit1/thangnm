#include <algorithm>
#include <iostream>
#include <utility>
#include <cassert>
#include <set>
#include <cstdio>
#include <string>
#include <cstdlib>
#include <cstring>
#include <fstream>
#include <iomanip>
using namespace std;

const int nmax = 100002;

typedef long long int64;
int n,ib,r,flg;
int64 k,t,m;
pair <int64, int > a[2*nmax];
ifstream fi ("My_Program.inp");
ofstream fo("My_Program.out");

int main()
{fi>>n>>k;
memset(a,0,sizeof(a));
a[0].first,a[0].second=0;
for (int i=1; i<=n;++i)
 { fi>>t;t-=k;
   a[i].first=a[i-1].first+t;
   a[i].second=i;      
 }
 stable_sort(a,a+n+1);
 /*
   fo<<" Sap xep:"<<endl;
   for(int i=0; i<=n;++i)
    fo<<setw(3)<<i<<setw(4)<<a[i].first<<setw(4)<<a[i].second<<endl;
   fo<<endl;        
 */
 flg=1;
 r=0; m=0;ib=0; a[n+1].first=a[n].first+10;
 for (int i = 1;i<=n+1;++i)
 {
   
   switch(flg)
     { case 1: if(a[i-1].first == a[i].first) {ib=a[i-1].second;flg=2; break;}
       case 2: if((flg==2) && (a[i-1].first!=a[i].first))
               { flg=1;t=a[i-1].second-ib; 
                 if(t>m||(t==m && ib<r)){r=ib+1; m=t; }}
     }
/*
  if(flg==1&& a[i-1].first == a[i].first)
     {ib=a[i-1].second;flg=2;}
     else {if (flg==2 && a[i-1].first!=a[i].first)
             { flg=1;t=a[i-1].second-ib; if(t>m){r=ib+1; m=t; }}
           }     
 */          
   //fo<<setw(3)<<i<<" M:"<<setw(4)<<m<<" IB:"<<setw(4)<<ib<<endl;  
}
  fo<<endl;
    if (m==0) fo<<m; else  fo<<m<<" "<<r;
 fi.close(); fo.close();   
}    