a=1:999;
sum(a(mod(a,3)==0 | mod(a,5)==0))