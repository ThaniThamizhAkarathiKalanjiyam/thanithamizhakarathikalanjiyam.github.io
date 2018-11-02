---
categories: blog
title: கிரந்த நீக்கி (For Developers)
keywords: 
- கிரந்த நீக்கி
- கிரந்தம்
description: நிரலர்கள் பின்வரும் நிரலைப் பயன்படுத்தி அவரர் இணையத் தளங்களில் கிரந்தப் பயன்பாட்டை குறைக்க முடியும். முடிந்தால் இந்த நிரலை மேம்படுத்த முயலாலாம்.
author: Tamilan
layout: Ruby
tags: 
 
permalink: kirantha_neekki_dev
featured: /images/ttak-48.png
---
## பொருளடக்கம்

- At your web page add the following section into your HEAD section:


```<script type="text/javascript" src="https://thanithamizhakarathikalanjiyam.github.io/ttakJs/ttak.kirantham.js"></script>```

Note: Please add the above code for kirantha neekki **integrated around the wrold wide** webpages.	

## வாடமொழி (கிரந்த) எழுத்துகளை மட்டும் மாற்ற:

- then which HTML elemnt you want to remove just use the following section appropriately.	


```var word = $("#kirantha_word_containg_element_name").val().trim();
alert(**kirantham_nekki**(word)) //word is a string contains the kirantha letters```

## வாடமொழி (கிரந்த) சொற்களை தமிழ்ச் சொற்களாக மாற்ற:

- then which HTML elemnt you want to remove just use the following section appropriately.	


```var word = $("#kirantha_word_containg_element_name").val().trim();
alert(**kirantham_nekki_thanithamizh**(word)) //word is a string contains the kirantha letters```


## Hvae Idea to contribute?

1. Go to https://github.com/ThaniThamizhAkarathiKalanjiyam/ttakJs
2. Make a **Fork** from the repository, 
3. Do changes and push to your cloned repository
4. Then make **Pull Request** to merge.

Thus we can remove the Kirantha world from the world-wide webpages.
	
Enjoy the ThaniTamil at your webpage.
