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

உங்களது வலைத் தளங்களை கிரந்த எழுத்துகளை நீக்கி எழுத/காண்பிக்க விழைகின்றீர்களா? உங்களுக்கான கட்டுரைதான் இது.

உங்களது இணையத் தளத்தில் உள்ள HTML கோப்பில் இரண்டு மாற்றங்களைச் செய்தாலே போதும். உங்களது இணையத் தல பயனர் கிரந்த சொற்கள் கொடுத்து பதிந்தாலும் அவை தனித்தமிழ்ச் சொற்களாக மாற்றப் படும். உதாரணமாக பின்வரும் எடுத்துக்காட்டை பாருங்கள். index.html என்னும் கோப்பை எடுத்துக் கொள்வோம்.

index.html:
	

 - At your web page add the following section into your HEAD section:

## வடமொழி (கிரந்த) எழுத்துகளை மட்டும் மாற்ற:
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

Note: Please add the above code for kirantha neekki **integrated around the wrold wide** webpages. Please use the  github integrated Javascript file only (means use [ttak.kirantham.js]( https://thanithamizhakarathikalanjiyam.github.io/ttakJs/ttak.kirantham.js) and [vadam.tamil.pairs.js]( https://thanithamizhakarathikalanjiyam.github.io/ttakJs/vadam.tamil.pairs.js)), maximum avoid use from your local website.

## தமிழ் அறிஞர்கள் கவனத்திற்கு

இந்தத் திட்டத்தில் தமிழ் ஆசிரியர்கள், அறிஞர்கள் பங்கெடுக்க அழைக்கிறோம். வடமொழிச் சொற்கள் தமிழ் மொழியினுள் புகுத்தப் பட்டு இருப்பின் அந்தச் சொற்களுக்கு இணையான தமிழ்ச் சொற்களை சேர்க்க உதவலாம். வடம் தமிழ் இணைச் சொற்கள் [சேர்க்கும் இடமாக இங்கு உள்ளது](https://github.com/ThaniThamizhAkarathiKalanjiyam/ttakJs/blob/master/vadam.tamil.pairs.js).

## Have Idea to contribute?

1. Go to [GitHub](https://github.com/ThaniThamizhAkarathiKalanjiyam/ttakJs)
2. Make a **Fork** from the repository, 
3. Do changes and push to your cloned repository
4. Then make **Pull Request** to merge world-wide kirantha-nekka-thittam.

Thus we can remove the Kirantha world from the world-wide webpages. Enjoy the ThaniTamil at your webpage.

# தனித்தமிழ் கலை கொண்டு பிறமொழிகளை களை
