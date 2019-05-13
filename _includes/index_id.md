**அஃக செயலியை நிறுவுவதன் மூலம் ..**

<p>உங்களது ஆன்ட்ராய்டு கைப்பேசியில் அஃக செயலி <a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/win_ttak/raw/ttak_apk/ttak_287.apk">Download</a> மூலம், உங்களால் (.slob வகை கோப்புகளை) கட்டுரைகளையும், தமிழ் அகராதியையும் படிக்க முடியும். மேலும் <a href="android">நிறுவல் வழிகாட்டியை காணவும்</a></p>

**புதிய நூல்கள் /கட்டுரைகள்**

{% assign post_titles = "" %}
{% assign post_count = 0 %}
{% assign posts_loc = (site.posts  ) %}
{% for post in posts_loc %}
{% if post.is_book != 1 and post_count < 11 and post.title != Nil %}
{% assign post_count = post_count | plus:1 %}
{% assign title_check = post.title | append:'|' %}
	{% if post_titles contains title_check %}
		{% assign empty = "" %}
	{% else %}
<div class="post">
<h2><a href="{{ site.url}}{{ post.url }}">{{ post.title }}</a></h2>
<p class="post-link">

Download: [Read Online]({{ site.url}}{{ post.url }}_1) | 
<a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal/{{ post.permalink }}.slob">slob</a> | <a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal/{{ post.permalink }}_A4.pdf">PDF</a> | <a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal/{{ post.permalink }}_6inch.pdf">pdf</a> | <a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal/{{ post.permalink }}_utf8.html">HTML (UTF8)</a> | <a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal/{{ post.permalink }}_tace16.html">HTML (TACE16)</a> | <a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/tam_ilakiyam/raw/master/Noolkal/{{ post.permalink }}_tace.txt">.txt</a>
</p>
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
{% endif %}
{% endfor %}

<h2><a class="post-link" href="more_books" class="button button2">Get more books ..
</a></h2>
