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
<h1>Staff</h1>

<ul>
  {% for author in site.authors %}
    <li>
      <h2><a href="{{ author.url }}">{{ author.name }}</a></h2>
      <h3>{{ author.position }}</h3>
      <p>{{ author.content | markdownify }}</p>
    </li>
  {% endfor %}
</ul>