cd /
rem /*
cd %~dp0
start D:\MPM_Dev_Center\PortableJekyll-master\setpath.cmd
jekyll --version
::bundle exec jekyll build -incremental
::jekyll serve -incremental 
bundle exec jekyll build & cd %~dp0\_site
GIT add . & git commit -am hiall & GIT PUSH