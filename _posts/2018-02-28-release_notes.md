---
categories: blog
title: வெளியீடுகள்
keywords: Releases, Notes
description: தனித்தமிழகராதிக்களஞ்சியத்தின் வெளியீடுகள் பற்றி தெரிந்து கொள்ளலாம்
author: Tamilan
layout: Ruby
tags:
 
permalink: release_notes
featured: /images/ttak-48.png
---

{% for post in site.posts %}
{% for tag in post.tags %}
{% if tag == "released" %}
<div class="post">
  <h2><a href="{{ post.permalink }}">{{ post.version_name }} பதிப்பு</a></h2>
  <p>{{ post.version }} வெளியிடப் பட்டுள்ளது.</p>
  <p><a href="https://github.com/ThaniThamizhAkarathiKalanjiyam/win_ttak/archive/{{ post.archive }}">தரவிறக்கம்</a></p>
  <p class="post-link"><a href="{{ post.permalink }}">மேலும் அறிய...</a></p>
  <p class="post-info">Posted by {{ post.author }} on {{ post.date | date_to_string }}</p>
</div>
{% endif %}
{% endfor %}
{% endfor %}
