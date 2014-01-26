green='\e[0;32m'
red='\e[1;31m'
endColour='\e[0m'

yes | sudo apt-add-repository ppa:octave/stable > /dev/null
sudo apt-get -qq update
sudo apt-get -qq install octave mono-vbnc > /dev/null

#C++
echo "C++ Tests"
for x in c++/*.cc
do 
  x=$(echo $x|cut -c 5- |rev| cut -c 4- |rev)
  g++ c++/$x.cc -o c++/$x -std=c++0x -O3 > /dev/null
  t="$(date +%s%N)"
  output=$(./c++/$x)
  t="$(($(date +%s%N)-t))"
  m="$((t/1000000))"
  answer=$(eval "sed -n '"$x"p' assets/answers.txt")
  if [ $output == $answer ]
  then 
    echo -e "${green}Problem $x solved in $m milliseconds ${endColour}"
  else 
    echo -e "${red}Problem $x failed ${endColour}"
  fi
done

#MATLAB
echo "MATLAB Tests"
for x in matlab/*.m
do
  t="$(date +%s%N)"
  output=$(octave -qf --no-window-system $x)
  t="$(($(date +%s%N)-t))"
  m="$((t/1000000))"
  x=$(echo $x|cut -c 8- |rev| cut -c 3- |rev)
  answer="ans =  $(eval "sed -n '"$x"p' assets/answers.txt")"
  if [ "$output" == "$answer" ]
  then 
    echo -e "${green}Problem $x solved in $m milliseconds ${endColour}"
  else 
    echo -e "${red}Problem $x failed ${endColour}"
  fi
done

#Python
echo "Python Tests"
for x in python/*.py
do
  t="$(date +%s%N)"
  output=$(python $x)
  t="$(($(date +%s%N)-t))"
  m="$((t/1000000))"
  x=$(echo $x|cut -c 8- |rev| cut -c 4- |rev)
  answer=$(eval "sed -n '"$x"p' assets/answers.txt")
  if [ "$output" == "$answer" ]
  then 
    echo -e "${green}Problem $x solved in $m milliseconds ${endColour}"
  else 
    echo -e "${red}Problem $x failed ${endColour}"
  fi
done

#Visual Basic
#echo "Visual Basic Tests"
#vbnc -nostdlib visual\ basic/001.vb
#ls visual\ basic/
#mono visual\ basic/001.exe