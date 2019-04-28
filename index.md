---
layout: Ruby
--- 
{% for post in site.posts limit:10 %}
<div class="post">
<h2><a href="{{ site.url}}/{{ post.url }}">{{ post.title }}</a></h2>
<p>{{ post.description }}</p>
<p class="post-link"><a href="{{ site.url}}/{{ post.url }}">இயங்கலையில் படிக்க . . .</a></p>
<p class="post-info">இறுதியாக பதிப்பித்த நாள் {{ post.date }}</p>
</div>
{% endfor %}


<h1>தமிழ்க் களஞ்சியம்</h1>
<ul>
<li>ஆண்டராய்டு கைப்பேசி தமிழ் அகராதி</li>
<li>இசையினி தமிழ் அகராதி</li>
<li>இசையினி ஆங்கிலம்-தமிழ் அகராதி</li>
<li>விண்டோசு கணினி தமிழ் அகராதி </li>
<li>இயங்கலை தமிழ் அகராதி</li>
<li>தமிழ் நூல்களின் பகிர்விடம்</li>
</ul>

<h2>TTAK வின் திட்டங்கள்</h2>
<ul>
<li><a href="android" target="_blank">கைப்பேசி</a></li>
<li><a href="ttak-web" target="_blank">கணினி</a></li>
<li><a href="ttak_tamil_ngaalakalanjiyam" target="_blank">தமிழ் ஞாலக் களஞ்சியம்</a></li>
</ul>

<h3>மடலாடல் குழுமம்</h3>
<ul>
<li><a href="https://groups.yahoo.com/neo/groups/isaiyini/info" target="_blank">இசையினி யாஹூ குழுமம்</a></li></ul>
