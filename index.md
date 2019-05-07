---
layout: Ruby
--- 
**புதிய நூல்கள் /கட்டுரைகள்**

{% assign post_titles = "" %}
{% for post in site.posts limit:11 %}
{% assign title_check = post.title | append:'|' %}
	{% if post_titles contains title_check %}
		{% assign empty = "" %}
	{% else %}
<div class="post">
<h2><a href="{{ site.url}}/{{ post.url }}">{{ post.title }}</a></h2>
<!--p>{{ post.description }}</p-->
<!--p class="post-link"><a href="{{ site.url}}/{{ post.url }}">இயங்கலையில் படிக்க . . .</a></p-->

{% for tag in post.tags %}
{% capture tag_name %}{{ tag }}{% endcapture %}
<a href="/tag/{{ tag_name }}"><code class="highligher-rouge"><nobr>{{ tag_name }}</nobr></code>&nbsp;</a>
{% endfor %}


{% if post.date %}
<p class="post-info">பதிவுற்ற நாள் {{ post.date | date_to_string }} | 
</p>
{% endif %}

{% endif %}
{% assign post_titles = post_titles | append:post.title | append:'|' %}
{% endfor %}

<h2><a class="post-link" href="more_books" class="button button2">Get more books ..
</a></h2>
