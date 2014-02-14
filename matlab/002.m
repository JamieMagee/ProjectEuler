f = zeros(40,1);
f(1) = 1;
f(2) = 2;
for k = 3:40
    f(k) = f(k-1) + f(k-2);
end
sum(f(mod(f,2) == 0 & f < 4e6))