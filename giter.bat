@echo off
chcp 65001
set /p commitMessage=Введите сообщение для коммита: 
git pull origin master
git add .
git commit -m "%commitMessage%"
git push origin master

echo Коммит и обновление выполнены успешно!
pause