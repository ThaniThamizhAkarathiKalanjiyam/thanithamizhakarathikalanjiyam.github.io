cd /
rem /*
cd %~dp0
::start D:\MPM_Dev_Center\PortableJekyll-master\setpath.cmd
::bundle exec jekyll build -incremental
::jekyll serve -incremental
bundle exec jekyll build 
cd _site
GIT add . 
git commit -am 
GIT PUSH