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

## வடமொழி (கிரந்த) எழுத்துகளை மட்டும் மாற்ற:

- At your web page add the following section into your HEAD section:

**HEAD Section Part:**

```<script type="text/javascript" src="https://thanithamizhakarathikalanjiyam.github.io/ttakJs/ttak.kirantham.js"></script>```

**How to use:**

- then which HTML element you want to remove just use the following section appropriately.	

**kirantham_nekki(word)**

```var word = $("#kirantha_word_containg_element_name").val().trim();
alert(kirantham_nekki(word)) //word is a string contains the kirantha letters```

## வடமொழி (கிரந்த) சொற்களை தமிழ்ச் சொற்களாக மாற்ற:

**HEAD Section Part:**

```<script type="text/javascript" src="https://thanithamizhakarathikalanjiyam.github.io/ttakJs/ttak.kirantham.js"></script>
<script type="text/javascript" src="https://thanithamizhakarathikalanjiyam.github.io/ttakJs/vadam.tamil.pairs.js"></script>```

**How to use:**

- then which HTML element you want to remove just use the following section appropriately.	

**kirantham_nekki_thanithamizh(word)**

```var word = $("#kirantha_word_containg_element_name").val().trim();
alert(kirantham_nekki_thanithamizh(word)) //word is a string contains the kirantha letters```

Note: Please add the above code for kirantha neekki **integrated around the wrold wide** webpages. Please use the  github integrated Javascript file only (means https://thanithamizhakarathikalanjiyam.github.io/ttakJs/ttak.kirantham.js and https://thanithamizhakarathikalanjiyam.github.io/ttakJs/vadam.tamil.pairs.js), maximum avoid use from local we site.

## தமிழ் அறிஞர்கள் கவனத்திற்கு

இந்தத் திட்டத்தில் தமிழ் ஆசிரியர்கள், அறிஞர்கள் பங்கெடுக்க அழைக்கிறோம். வடமொழிச் சொற்கள் தமிழ் மொழியினுள் புகுத்தப் பட்டு இருப்பின் அந்தச் சொற்களுக்கு இணையான தமிழ்ச் சொற்களை சேர்க்க உதவலாம். வடம் தமிழ் இணைச் சொற்கள் [சேர்க்கும் இடமாக இங்கு உள்ளது](https://github.com/ThaniThamizhAkarathiKalanjiyam/ttakJs/blob/master/vadam.tamil.pairs.js).

## Have Idea to contribute?

1. Go to [GitHub](https://github.com/ThaniThamizhAkarathiKalanjiyam/ttakJs)
2. Make a **Fork** from the repository, 
3. Do changes and push to your cloned repository
4. Then make **Pull Request** to merge world-wide kirantha-nekka-thittam.

Thus we can remove the Kirantha world from the world-wide webpages. Enjoy the ThaniTamil at your webpage.

# தனித்தமிழ் கலை கொண்டு பிறமொழிகளை களை
