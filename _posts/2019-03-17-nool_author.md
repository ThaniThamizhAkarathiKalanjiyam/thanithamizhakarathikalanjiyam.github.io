---  
categories: blog  
title: நூலாசிரியர்கள்
keywords: More, Tamil, Books  
description: நூலாசிரியர்கள் பட்டியல்
author: Tamilan  
layout: Ruby  
tags:     

permalink: nool_author
featured: /images/noolkal_96_6.png  
---
{% for author in site.authors %}
- <a href="{{ author.url }}">{{ author.name }}</a>
	- {{ author.position }}
<!--p>{{ author.content | markdownify }}</p-->
{% endfor %}
