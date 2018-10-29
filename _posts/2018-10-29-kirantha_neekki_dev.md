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



	<h2>கிரந்தச் சொல்லை இங்கு இடுங்கள்</h2>
	<textarea id="kirantha_word" rows="4" cols="50">
	கிரந்தச் சொல் (புஷ்கர்)
	</textarea>
	<br/>
	<button class="button" onclick="ChangetToTamil()">Click</button>
	<h2>தமிழ்ச் சொல்லை இங்கு பாருங்கள்</h2>
	<textarea id="tamil_word" rows="4" cols="50">
	தமிழ்ச் சொல் (புட்கர்)
	</textarea>
	<script>
	function ChangetToTamil()
	{
	var input = $("#kirantha_word").val().trim(); 
		input = input
			.replace("ஸ்ரீ", "திரு")
			.replace("க்ல", "க்கில")
			.replace("க்ர", "க்கிர")
			.replace("்ம", "ும")
			.replace("்வ", "ுவ");
			
		var input1 = input;
		var lastChar = ' ',
		nextChar = ' ',
		curChar = ' ';
		var CharIndex = 0,
			lastIndex = 0,
			nextIndex = 0;
		try
		{
			//log.Info("692018125837PM1 started");
			//string FinalString = "";
			for (CharIndex = 0; CharIndex < input.length; CharIndex++)
			{
				lastIndex = CharIndex - 1;
				nextIndex = CharIndex + 1;
				if (lastIndex >= 0)
				{
					lastChar = input[lastIndex];
				}
				//if (CharIndex)
				//{
				curChar = input[CharIndex];
				//}
				if (nextIndex < input.Length)
				{
					nextChar = input[nextIndex];
				}
				else
				{
					nextChar = ' ';
				}
				var theWholeString = "" + lastChar + curChar + nextChar;
				if (CharIndex == 0)
				{
					if (theWholeString == " ர்")
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "இ");
					}
					else if ((theWholeString == " ஷா" ||
					   theWholeString == " ஸா"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "சா");
					}
					else if ((input1.substring(0, 3) == "க்ஷ"))
					{
						input1 = input1.replace(input1.substring(0, 3),
						   "க");
					}
					else if ((input[CharIndex] == 'ஷ' ||
						input[CharIndex] == 'ஸ' ||
						input[CharIndex] == 'ஜ'))
					{
						if (input1.substring(0, 3) == "ஸ்வ"
							|| input1.substring(0, 3) == "ஷ்வ"
							)
						{
							input1 = input1.replace(input1.substring(0, 3),
							   "சுவ");
						}
						else if (input1.substring(0, 3) == "ஸ்த"
								|| input1.substring(0, 3) == "ஷ்த")
						{
							input1 = input1.replace(input1.substring(0, 3),
							   "த");
						}
						else if (input1.substring(0, 3) == "ஸ்க"
								|| input1.substring(0, 3) == "ஷ்க")
						{
							input1 = input1.replace(input1.substring(0, 3),
							   "க");
						}
						else if (input1.substring(0, 3) == "ஸ்ட"
								|| input1.substring(0, 3) == "ஷ்ட")
						{
							input1 = input1.replace(input1.substring(0, 3),
							   "ச");
						}
						else if (input1.substring(0, 3) == "ஸ்ப"
								|| input1.substring(0, 3) == "ஷ்ப")
						{
							input1 = input1.replace(input1.substring(0, 3),
							   "ப");
						}
						else
						{
							input1 = input1.replace(input1.substring(0, 1),
							   "ச");
						}
					}
					else if ((input[CharIndex] == 'ஹ'))
					{
						if (input1.substring(0, 2) == ("ஹௌ"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஔ");
						}
						// .replace("ஹோ", "ஓ")
						else if (input1.substring(0, 2) == ("ஹோ"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஓ");
						}
						// .replace("ஹொ", "ஒ")
						else if (input1.substring(0, 2) == ("ஹொ"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஒ");
						}
						// .replace("ஹை", "ஐ")
						else if (input1.substring(0, 2) == ("ஹை"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஐ");
						}
						// .replace("ஹே", "ஏ")
						else if (input1.substring(0, 2) == ("ஹே"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஏ");
						}
						// .replace("ஹே", "எ")
						else if (input1.substring(0, 2) == ("ஹே"))
						{
							input1 = input1.replace(input1.substring(0, 2), "எ");
						}
						// .replace("ஹூ", "ஊ")
						else if (input1.substring(0, 2) == ("ஹூ"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஊ");
						}
						// .replace("ஹு", "உ")
						else if (input1.substring(0, 2) == ("ஹு"))
						{
							input1 = input1.replace(input1.substring(0, 2), "உ");
						}
						// .replace("ஹீ", "ஈ")
						else if (input1.substring(0, 2) == ("ஹீ"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஈ");
						}
						// .replace("ஹி", "இ")
						else if (input1.substring(0, 2) == ("ஹி"))
						{
							input1 = input1.replace(input1.substring(0, 2), "இ");
						}
						// .replace("ஹா", "ஆ")
						else if (input1.substring(0, 2) == ("ஹா"))
						{
							input1 = input1.replace(input1.substring(0, 2), "ஆ");
						}
						//.replace("ஹ", "அ")
						else
						{
							input1 = input1.replace(input1.substring(0, 1),
							 "அ");
						}
					}
					else if ((theWholeString == " ரொ"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "உரொ");
					}
					else if ((theWholeString == " ரோ"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "உரோ");
					}
					else if ((theWholeString == " ரி"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "இ");
					}
					else if ((theWholeString == " ரா"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "இரா");
					}
					else if ((input[CharIndex] == 'ர'))
					{
						input1 = input1.replace(input1.substring(0, 1),
						   "அர");
					}
					//--------------------
					else if ((theWholeString == " லொ"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "உலொ");
					}
					else if ((theWholeString == " லோ"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "உலோ");
					}
					else if ((theWholeString == " லி"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "இலி");
					}
					else if ((theWholeString == " லா"))
					{
						input1 = input1.replace(input1.substring(0, 2),
						   "இலா");
					}
					else if ((input[CharIndex] == 'ல'))
					{
						input1 = input1.replace(input1.substring(0, 1),
						   "அல");
					}
				}
				else if (CharIndex == input1.Length - 1 && input1[CharIndex] == 'ா')
				{
					//input1 = input[CharIndex];
					input1 = input1.substring(0, (CharIndex))
						+ "ை";
				}
				else if (CharIndex == 2 && theWholeString == "ிர்")
				{
					//input1 = input[CharIndex];
					input1 = input1.replace(input1.substring(0, 4),
						input1.substring(0, 3) + "ு");
				}
				else
				{
					input1 = input1
						.replace("க்ஷ", "க்க")
						.replace("ஜ", "ய")
						.replace("ஷ", "ட")
						.replace("ஸ", "ச")
						.replace("ஹ", "க")
						.replace("்ந", "ன")
						;
				}
				//MessageBox.Show("CharIndex: " 
				//+ CharIndex + ", " 
				//+ theWholeString + ":: \nlastChar: " 
				//+ lastChar
				//    + "\n curChar: " + curChar
				//    + "\n nextChar: " + nextChar);
			}
			//log.Info("692018125837PM2 end");
		}
		catch (err)
		{
			//log.Error(string.Format("692018125837PM3 {0}", ex.Message));
			alert(err.message);
		}
		finally
		{
			//log.Info("692018125837PM4 Process is done.");
		}
		$("#tamil_word").val(input1);
	}
	</script>