--- 
categories: blog 
title: தனித்தமிழ் ஞாலக் களஞ்சியம்
keywords: More, Tamil, Books 
description: தமிழறிஞர்களின் நூல்கள் , தனித்தமிழ் ஞாலக் களஞ்சியம்
author: Tamilan 
layout: seamonkey 
tags:  
permalink: ttak_tamil_ngaalakalanjiyam 
featured: /images/noolkal_96_6.png 
--- 
 
{% comment %}
=======================
The following part extracts all the tags from your posts and sort tags, so that you do not need to manually collect your tags to a place.
=======================
{% endcomment %}
{% assign rawtags = "" %}
{% for post in site.posts %}
 {% assign ttags = post.tags | join:'|' | append:'|' %}
 {% assign rawtags = rawtags | append:ttags %}
{% endfor %}
{% assign rawtags = rawtags | split:'|' | sort %}

{% comment %}
=======================
The following part removes dulpicated tags and invalid tags like blank tag.
=======================
{% endcomment %}
{% assign tags = "" %}
{% for tag in rawtags %}
 {% if tag != "" %}
  {% if tags == "" %}
   {% assign tags = tag | split:'|' %}
  {% endif %}
  {% unless tags contains tag %}
   {% assign tags = tags | join:'|' | append:'|' | append:tag | split:'|' %}
  {% endunless %}
 {% endif %}
{% endfor %}

{% comment %}
=======================
The purpose of this snippet is to list all your posts posted with a certain tag.
=======================
{% endcomment %}
{% assign tag_counter = 1 %}
{% for tag in tags %}
<P><B>{{ tag_counter }} <a name="{{ tag }}">{{ tag }}</a> நூல்கள்</B>:</P>  
<TABLE cellspacing ="1" cellpadding ="6" border = "0">
  <thead>
    <tr>
      <th class="Title" align="center">நூல்</th>
      <th class="Title" align="center">தரவிறக்கம்</th>      
			{% if tag != "அகராதிகள்" %}	
			<th class="Title" align="center">தேடுசொல்</th>      			
			{% endif %}
    </tr>
  </thead>
  <tfoot>
    <tr>
      <td class="bottom-left"></td>
      <td colspan="4"></td>
      <td class="bottom-right"></td>
    </tr>
  </tfoot>
  <tbody>
  
{% assign post_counter = 1 %}
{% for post in site.posts %}
{% if post.tags contains tag %}
{% assign tag_counter_mod = forloop.index | modulo: 2 %}


	<tr id="id_{{ tag_counter }}" >
	<td class="Item">
	
	{{ tag_counter }}.{{ post_counter }}. <a href="{{ post.url }}"><b>{{ post.title }}</b></a>
	
	</td>
	<td class="Item" align="center"><img src="images/Save.JPG" alt="save"/> <a href = "https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal{{ post.url }}.slob"> Download </a></td>	
	
	{% if tag != "அகராதிகள்" %}	
		<td class="Item" align="center">"{{ post.title }}/"</td>	
	{% endif %}
	</tr>


{% assign post_counter = post_counter | plus:1 %}
{% endif %}
{% endfor %}
  <tr><td colspan="3">Please install <a href="#niruval">அஃக ௨௮௭</a> for reading the book</td></tr>
  </tbody>
</table>
{% assign tag_counter = tag_counter | plus:1 %}
{% endfor %}

<a name="niruval"> கைப்பேசியில் நிறுவல் முறை</a>

{% include install_nool_2.md %} 