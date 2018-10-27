# Tag: {{ page.tag }}

{% for post in site.tags[page.tag] %}
- [{{ post.url }}]({{ post.title }}) ({{ post.date | date_to_string }})
    {{ post.description }}  
{% endfor %}

