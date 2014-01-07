green='\e[0;32m'
red='\e[1;31m'
endColour='\e[0m'

yes | sudo apt-add-repository ppa:octave/stable > /dev/null
sudo apt-get -qq update
sudo apt-get -qq install octave > /dev/null

#C++
echo "C++ Tests"
for x in c++/*.cc
do 
  x=$(echo $x|cut -c 5- |rev| cut -c 4- |rev)
  make c++ $x > /dev/null
  output=$(./c++/$x)
  answer=$(eval "sed -n '"$x"p' assets/answers.txt")
  if [ $output == $answer ]
  then 
    echo -e "${green}Test $x passed${endColour}"
  else 
    echo -e "${red}Test $x failed${endColour}"
  fi
done

#MATLAB
echo "MATLAB Tests"
for x in matlab/*.m
do
  output=$(octave -qf --no-window-system $x)
  x=$(echo $x|cut -c 8- |rev| cut -c 3- |rev)
  answer="ans =  $(eval "sed -n '"$x"p' assets/answers.txt")"
  if [ "$output" == "$answer" ]
  then 
    echo -e "${green}Test $x passed${endColour}"
  else 
    echo -e "${red}Test $x failed${endColour}"
  fi
done