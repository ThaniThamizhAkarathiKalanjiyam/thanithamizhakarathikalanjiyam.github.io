---  
categories: blog  
title: தமிழ் நாட்காட்டி
keywords: More, Tamil, Books  
description: தமிழ் நாட்காட்டி jquery-ui plugin Model
author: Tamilan  
layout: Ruby  
tags:     
- நாட்காட்டி
permalink: datepicker_ta  
featured: /images/noolkal_96_6.png  
---  

## தமிழ் நாட்காட்டியின் மாதிரி வடிவம்
[Demo](https://thanithamizhakarathikalanjiyam.github.io/jquery-ui/demos/datepicker_ta/)

<div id="datepicker_ta"></div>
<script>
$(function(){
	$( "#datepicker_ta" ).datepicker_ta({
		inline: true,	
	});
});
</script>

[More details see google spreadsheet](https://docs.google.com/spreadsheets/d/1dpVwd7wg_EOewXOLZUX56y7k3y_QW9s8kTjFrBzAYFI/edit?usp=sharing_eip&ts=5d47af24)


## Try this at your websites
You can make this plugin workable at your site in three steps.

### 1. Add following sections at your HEAD tag
	
	<-script src="https://thanithamizhakarathikalanjiyam.github.io/external/TamilCalendar/calendar_ta.js"></script>	
	<-script src="https://thanithamizhakarathikalanjiyam.github.io/jquery-ui/ui/widgets/datepicker_ta.js"></script>
	
**Dependencies:**

- [jquery-ui.css](https://jqueryui.com)
- [jquery-ui.js](https://jqueryui.com)
- [jQuery](https://jquery.com) (1.7+)

	
### 2. Add following code at your BODY section where you needed
	<div id="datepicker_tamil"></div>

### 3. Make the tamil date at your site live 
Just add following section at bottom of your site before closing tag of your site body tag.
	
	-<-script>
	$( function() {
		$( "#datepicker_tamil" ).datepicker_ta();
	} );
	</script>


## இணையத் தளங்களில் பயன்படுத்தும் முறை

A model HTML file (see the sections inside **. And while deployment remove the *'s from your html file)

	&nbsp;&nbsp;&nbsp; &lt;!doctype html&gt;<br>
	&nbsp;&nbsp; &nbsp;&lt;html lang="en"&gt;<br>
	&nbsp;&nbsp; &nbsp;&lt;head&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;meta charset="utf-8"&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;meta name="viewport"
	content="width=device-width, initial-scale=1"&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;title&gt;jQuery UI Datepicker -
	Default functionality&lt;/title&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;link rel="stylesheet"
	href="http://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;!--link rel="stylesheet"
	href="/resources/demos/style.css"--&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;script
	src="https://code.jquery.com/jquery-1.12.4.js"&gt;&lt;/script&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;script
	src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"&gt;&lt;/script&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;script
	src="https://thanithamizhakarathikalanjiyam.github.io/jquery-ui/external/TamilCalendar/calendar_ta.js"&gt;&lt;/script&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp; &lt;script
	src="https://thanithamizhakarathikalanjiyam.github.io/jquery-ui/ui/widgets/datepicker_ta.js"&gt;&lt;/script&gt;<br>
	&nbsp;&nbsp; &nbsp;<br>
	&nbsp;&nbsp; &nbsp;&lt;/head&gt;<br>
	&nbsp;&nbsp; &nbsp;&lt;body&gt;<br>
	&nbsp;&nbsp; &nbsp; <br>
	&nbsp;&nbsp; &nbsp;&lt;div id="datepicker_tamil"&gt;&lt;/div&gt;<br>
	<br>
	&nbsp;&nbsp; &nbsp;&lt;script&gt;<br>
	&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;$(function(){<br>
	&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;$(
	"#datepicker_tamil" ).datepicker_ta({<br>
	&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
	&nbsp;&nbsp;&nbsp; &nbsp;inline: true,&nbsp;&nbsp; &nbsp;<br>
	&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;});<br>
	&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;});<br>
	&nbsp;&nbsp; &nbsp;&lt;/script&gt;<br>
	&nbsp;&nbsp; &nbsp; <br>
	&nbsp;&nbsp; &nbsp;&lt;/body&gt;<br>
	&nbsp;&nbsp; &nbsp;&lt;/html&gt;

