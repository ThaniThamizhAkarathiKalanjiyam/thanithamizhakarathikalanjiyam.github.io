::cd /
::rem /*
cd %~dp0
D:\MPM_Dev_Center\PortableJekyll-master\setpath-ry31.cmd jekyll --version
bundle exec jekyll build -d D:\GitRepo\thanithamizhakarathikalanjiyam.github.io
::cd %~dp0\_site & GIT add . & git commit -am hiall & GIT PUSH
cd D:\GitRepo\thanithamizhakarathikalanjiyam.github.io & GIT add . & git commit -am hiall & GIT PUSH