---
layout: Ruby
--- 

<div id="intro-wrapper">
  <div id="intro">
    <h1>Ruby is...</h1>

    <p>
    A dynamic, open source programming language with a focus on
    simplicity and productivity. It has an elegant syntax that is
    natural to read and easy to write.
    </p>

    <a href="downloads/" class="download-link">Download Ruby</a>
    or
    <a href="about/">Read More...</a>

  </div>
  <div id="code">
<figure class="highlight"><pre><code class="language-ruby" data-lang="ruby"><span class="c1"># Output "I love Ruby"</span>
<span class="n">say</span> <span class="o">=</span> <span class="s2">"I love Ruby"</span>
<span class="nb">puts</span> <span class="n">say</span>

<span class="c1"># Output "I *LOVE* RUBY"</span>
<span class="n">say</span><span class="p">[</span><span class="s1">'love'</span><span class="p">]</span> <span class="o">=</span> <span class="s2">"*love*"</span>
<span class="nb">puts</span> <span class="n">say</span><span class="p">.</span><span class="nf">upcase</span>

<span class="c1"># Output "I *love* Ruby"</span>
<span class="c1"># five times</span>
<span class="mi">5</span><span class="p">.</span><span class="nf">times</span> <span class="p">{</span> <span class="nb">puts</span> <span class="n">say</span> <span class="p">}</span></code></pre></figure>

</div>
</div>

{% for post in site.posts limit:10 %}
<div class="post">
<h2><a href="{{ site.url}}/{{ post.url }}">{{ post.title }}</a></h2>
<p>{{ post.description }}</p>
<p class="post-link"><a href="{{ site.url}}/{{ post.url }}">இயங்கலையில் படிக்க . . .</a></p>
<p class="post-info">இறுதியாக பதிப்பித்த நாள் {{ post.date }}</p>
</div>
{% endfor %}
