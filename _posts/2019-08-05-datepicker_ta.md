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

	<!doctype html>
    <html lang="en">
    <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <title>jQuery UI Datepicker - Default functionality</title>
      <link rel="stylesheet" href="http://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
      <!--link rel="stylesheet" href="/resources/demos/style.css"-->
      <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
      <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
      <script src="https://thanithamizhakarathikalanjiyam.github.io/jquery-ui/external/TamilCalendar/calendar_ta.js"></script>
      <script src="https://thanithamizhakarathikalanjiyam.github.io/jquery-ui/ui/widgets/datepicker_ta.js"></script>    
    </head>
    <body>    
		<div id="datepicker_tamil"></div>
		<script>
			$(function(){
				$( "#datepicker_tamil" ).datepicker_ta({
					inline: true,    
				});
			});
		</script>    
    </body>
    </html>
	
## இந்த நிரல்-சொருகி (JQuery-ui Plugin) உருவாக உதவியவர்கள்

மின்தமிழ் குழும உறுப்பினர்களின் உதவியால் இந்த சோதனை ஓட்ட JQuery-ui Plugin for Tamil Datepicker உருவாக்கம் பெற்று உள்ளது

- இரவிஅண்ணாசாமி
- இன்னம்பூரான்
- தேமொழி
- கந்தன்
- சேதுராமன் 
- கண்மணி

அனைவருக்கும் இசையினி குழுமத்தின் சார்பாக நன்றிகள் பல. 

## தமிழ் இணையத்தள உரிமையாளர்களுக்கு

மேலும் இந்த சொருகு-நிரலை உங்களின் இணையத்தில் செயல்படுத்தி தமிழ் மாதங்களை அனைவரிடமும் பிரபலம் செய்ய முடியும். உங்களின் இணைய தளத்தில் தமிழ் மாத இந்த நிரலை வெளியிட தொழில் நுட்ப உதவிகள் தேவைப்பட்டால் திறந்த மனதுடன் எங்களுக்கு ஒரு மிஞ்சல் செய்யவும். முகவரி isaiyini@yahoogroups.com.

நன்றிகள் பல.


