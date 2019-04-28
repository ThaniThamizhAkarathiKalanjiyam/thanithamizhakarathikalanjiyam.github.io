---
layout: Ruby
--- 
{% for post in site.posts limit:5 %}
<div class="post">
<h2><a href="{{ site.url}}/{{ post.url }}">{{ post.title }}</a></h2>
<p>{{ post.description }}</p>
<p class="post-link"><a href="{{ site.url}}/{{ post.url }}">இயங்கலையில் படிக்க . . .</a></p>
<p class="post-info">இறுதியாக பதிப்பித்த நாள் {{ post.date }}</p>
</div>
{% endfor %}
