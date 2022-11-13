var today = new Date();
var eng_month = today.getMonth();
var eng_year = today.getYear();
var yrMap = [
{
    engYear: 2018,
    engTaMap : [	
		{eMM:0,taMM:9,taDD:18},//Jan
		{eMM:1,taMM:10,taDD:18},//Feb
		{eMM:2,taMM:11,taDD:18},//Mar
		{eMM:3,taMM:12,taDD:18},//Apr
		     
		{eMM:4,taMM:1,taDD:18},//May
		{eMM:5,taMM:2,taDD:18},//Jun
		{eMM:6,taMM:3,taDD:16},//Jul
		{eMM:7,taMM:4,taDD:16},//Aug
		{eMM:8,taMM:5,taDD:15},//Sep
		{eMM:9,taMM:6,taDD:14},//Oct
		{eMM:10,taMM:7,taDD:13},//Nov
		{eMM:11,taMM:8,taDD:15},//Dec
	]
},
{
    engYear: 2019,
    engTaMap : [	
		{eMM:0,taMM:9,taDD:18},//Jan
		{eMM:1,taMM:10,taDD:18},//Feb
		{eMM:2,taMM:11,taDD:18},//Mar
		{eMM:3,taMM:12,taDD:18},//Apr
		     
		{eMM:4,taMM:1,taDD:18},//May
		{eMM:5,taMM:2,taDD:18},//Jun
		{eMM:6,taMM:3,taDD:16},//Jul
		{eMM:7,taMM:4,taDD:16},//Aug
		{eMM:8,taMM:5,taDD:15},//Sep
		{eMM:9,taMM:6,taDD:14},//Oct
		{eMM:10,taMM:7,taDD:13},//Nov
		{eMM:11,taMM:8,taDD:15},//Dec
	]
},
{
    engYear: 2020,
    engTaMap : [	
		{eMM:0,taMM:9,taDD:16},//Jan
		{eMM:1,taMM:10,taDD:18},//Feb
		{eMM:2,taMM:11,taDD:17},//Mar
		{eMM:3,taMM:12,taDD:19},//Apr
		     
		{eMM:4,taMM:1,taDD:18},//May
		{eMM:5,taMM:2,taDD:18},//Jun
		{eMM:6,taMM:3,taDD:16},//Jul
		{eMM:7,taMM:4,taDD:16},//Aug
		{eMM:8,taMM:5,taDD:15},//Sep
		{eMM:9,taMM:6,taDD:14},//Oct
		{eMM:10,taMM:7,taDD:13},//Nov
		{eMM:11,taMM:8,taDD:15},//Dec
	]
},
];

var TC = {			
		lunarInfo: new Array(0x04bd8, 0x04ae0, 0x0a570, 0x054d5, 0x0d260, 0x0d950, 0x16554, 0x056a0, 0x09ad0, 0x055d2, 0x04ae0, 0x0a5b6, 0x0a4d0, 0x0d250, 0x1d255, 0x0b540, 0x0d6a0, 0x0ada2, 0x095b0, 0x14977, 0x04970, 0x0a4b0, 0x0b4b5, 0x06a50, 0x06d40, 0x1ab54, 0x02b60, 0x09570, 0x052f2, 0x04970, 0x06566, 0x0d4a0, 0x0ea50, 0x06e95, 0x05ad0, 0x02b60, 0x186e3, 0x092e0, 0x1c8d7, 0x0c950, 0x0d4a0, 0x1d8a6, 0x0b550, 0x056a0, 0x1a5b4, 0x025d0, 0x092d0, 0x0d2b2, 0x0a950, 0x0b557, 0x06ca0, 0x0b550, 0x15355, 0x04da0, 0x0a5d0, 0x14573, 0x052d0, 0x0a9a8, 0x0e950, 0x06aa0, 0x0aea6, 0x0ab50, 0x04b60, 0x0aae4, 0x0a570, 0x05260, 0x0f263, 0x0d950, 0x05b57, 0x056a0, 0x096d0, 0x04dd5, 0x04ad0, 0x0a4d0, 0x0d4d4, 0x0d250, 0x0d558, 0x0b540, 0x0b5a0, 0x195a6, 0x095b0, 0x049b0, 0x0a974, 0x0a4b0, 0x0b27a, 0x06a50, 0x06d40, 0x0af46, 0x0ab60, 0x09570, 0x04af5, 0x04970, 0x064b0, 0x074a3, 0x0ea50, 0x06b58, 0x055c0, 0x0ab60, 0x096d5, 0x092e0, 0x0c960, 0x0d954, 0x0d4a0, 0x0da50, 0x07552, 0x056a0, 0x0abb7, 0x025d0, 0x092d0, 0x0cab5, 0x0a950, 0x0b4a0, 0x0baa4, 0x0ad50, 0x055d9, 0x04ba0, 0x0a5b0, 0x15176, 0x052b0, 0x0a930, 0x07954, 0x06aa0, 0x0ad50, 0x05b52, 0x04b60, 0x0a6e6, 0x0a4e0, 0x0d260, 0x0ea65, 0x0d530, 0x05aa0, 0x076a3, 0x096d0, 0x04bd7, 0x04ad0, 0x0a4d0, 0x1d0b6, 0x0d250, 0x0d520, 0x0dd45, 0x0b5a0, 0x056d0, 0x055b2, 0x049b0, 0x0a577, 0x0a4b0, 0x0aa50, 0x1b255, 0x06d20, 0x0ada0),
		tamilWeekDayNames: ["", "திங்கள்", "செவ்வாய்", "புதன் ", "வியாழன்", "வெள்ளி", "சனி ", "ஞாயிறு"],
		tamilYearName: new Array("","பிரபவ","விபவ","சுக்ல","பிரமோதூத","பிரசோற்பத்தி","ஆங்கீரச","ஸ்ரீமுக","பவ","யுவ","தாது","ஈஸ்வர","வெகுதானிய","பிரமாதி","விக்கிரம","விஷு","சித்திரபானு","சுபானு","தாரண","பார்த்திப","விய","சர்வசித்து","சர்வதாரி","விரோதி","விக்ருதி","கர","நந்தன","விஜய","ஜய","மன்மத","துன்முகி","ஹேவிளம்பி","விளம்பி","விகாரி","சார்வரி","பிலவ","சுபகிருது","சோபகிருது","குரோதி","விசுவாசுவ","பரபாவ","பிலவங்க","கீலக","சௌமிய","சாதாரண","விரோதகிருது","பரிதாபி","பிரமாதீச","ஆனந்த","ராட்சச","நள","பிங்கள","காளயுக்தி","சித்தார்த்தி","ரௌத்திரி","துன்மதி","துந்துபி","ருத்ரோத்காரி","ரக்தாட்சி","குரோதன","அட்சய"),
		tamilMonthName: new Array("","சித்திரை", "வைகாசி", "ஆனி", "ஆடி", "ஆவணி", "புரட்டாசி", "ஐப்பசி", "கார்த்திகை", "மார்கழி", "தை", "மாசி", "பங்குனி"),
		peruPoluthu: new Array("","இளவேனில்", "முதுவேனில்", "கார்", "கூதிர்", "முன்பனி", "பின்பனி"),
		siruPoluthu: new Array("","வைகறை", "காலை", "நண்பகல்", "எற்பாடு", "மாலை", "யாமம்"),
		getTamilSeason: function (ta_month) {
			if(ta_month === undefined){
				ta_month = TC.tamilMonth();
			}
			tamil_season = 0;
			if (ta_month <= 2)
				tamil_season = 1;
			else if (ta_month <= 4)
				tamil_season = 2;
			else if (ta_month <= 6)
				tamil_season = 3;
			else if (ta_month <= 8)
				tamil_season = 4;
			else if (ta_month <= 10)
				tamil_season = 5;
			else if (ta_month <= 12)
				tamil_season = 6;
			
			return TC.peruPoluthu[tamil_season];
		},
		getTamilDayPoluthu: function (eng_time) {
			if(eng_time === undefined){
				eng_time = today.getHours();			
			}
			if (eng_time > 2 && eng_time <= 6)
				return 1;
			else if (eng_time > 6 && eng_time <= 10)
				return 2;
			else if (eng_time > 10 && eng_time <= 14)
				return 3;
			else if (eng_time > 14 && eng_time <= 18)
				return 4;
			else if (eng_time > 18 && eng_time <= 22)
				return 5;
			else if (eng_time > 22 && eng_time <= 2)
				
				return 6;
		},
		tamilDate: function (y, m, d) {
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			var td = 0;
			var i;
			var daysInMonth = TC._getDaysInMonth(y, m);
			
			for (i = 0; i < yrMap.length; i++)
			{
				if(yrMap[i].engYear == y)
				{
					var j;
					for (j =0; j < yrMap[i].engTaMap.length; j++)
					{
						var preMonth = yrMap[i].engTaMap[j-1];
						var curMonth = yrMap[i].engTaMap[j];
						var nxtMonth = yrMap[i].engTaMap[j+1];	
						var nxtMonth;
						//TODO If the english month is december error occured
						if(curMonth.eMM == 11)
						{
							nxtMonth = yrMap[i+1].engTaMap[(j+1) - curMonth.eMM];
						}
						else
						{
							nxtMonth = yrMap[i].engTaMap[j+1];
						}
						if(curMonth.eMM == m){
							var nxtMonthDays = nxtMonth.taDD;
							var curMonthReamingDays = daysInMonth - nxtMonthDays;
							var curMonthStartingDay = curMonth.taDD;
							var daysInCurTamilMonth = curMonthReamingDays + curMonthStartingDay;
														
							td = curMonth.taDD + d - 1;
							if(td > daysInCurTamilMonth)
							{
								td = td - daysInCurTamilMonth;							
							}
							
							break;							
						}
					}
				}
			}
			
			return td;						
		},
		tamilMonth: function (y, m, d) {
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			tm = 0;
			var i;
			var daysInMonth = TC._getDaysInMonth(y, m);
			var td = 0;
			for (i =0; i < yrMap.length; i++){
				if(yrMap[i].engYear == y){
					var j;
					for (j =0; j < yrMap[i].engTaMap.length; j++){	
						var preMonth = yrMap[i].engTaMap[j-1];
						var curMonth = yrMap[i].engTaMap[j];
						var nxtMonth;
						//TODO If the english month is december error occured
						if(curMonth.eMM == 11)
						{
							nxtMonth = yrMap[i+1].engTaMap[(j+1) - curMonth.eMM];
						}
						else
						{
							nxtMonth = yrMap[i].engTaMap[j+1];
						}
						if(curMonth.eMM == m){
							var nxtMonthDays = nxtMonth.taDD;
							var curMonthReamingDays = daysInMonth - nxtMonthDays;
							var curMonthStartingDay = curMonth.taDD;
							var daysInCurTamilMonth = curMonthReamingDays + curMonthStartingDay;
							
							td = curMonth.taDD + d - 1;
							if(td > daysInCurTamilMonth)
							{
								tm = curMonth.taMM + 1;
							}							
							else									
							{
								tm = curMonth.taMM;
							}
							break;
						}													
					}
				}
			}
			return tm;
		},
		getTamilMonthName: function (y, m, d) {
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			tm = TC.tamilMonth(y, m, d);
			return TC.tamilMonthName[tm];
		},
		tamilYear: function (y, m, d) {
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			//Tamil new year start at april month.
			//ToDO caluculate the before 14 date of april
			if(m <= 4 )			
				if(d <= 14)
					y = y - 1;			
			taYear = ((y + 53) % 60) + 1;
			
			return taYear;
		},
		monthDays: function (y, m) {
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			
		},
		getTamilYearName: function (y, m, d) {
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			taYear = TC.tamilYear(y, m, d);
			return TC.tamilYearName[taYear];
		},
		getTVAandu: function (y, m, d) {
			tvandu = 0;
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			tvandu = y + 31;
			return tvandu;
		},
		getKaliYugaAandu: function (y, m, d) {
			kaliYugaAandu = 0;
			if(y === undefined){
				y = today.getFullYear ();
				m = today.getMonth();
				d = today.getDate();
			}
			kaliYugaAandu = y + 3101;
			return kaliYugaAandu;
		},
		/* Find the number of days in a given month. */
		_getDaysInMonth: function( year, month ) {
			return 32 - this._daylightSavingAdjust( new Date( year, month, 32 ) ).getDate();
		},
		/* Handle switch to/from daylight saving.
		* Hours may be non-zero on daylight saving cut-over:
		* > 12 when midnight changeover, but then cannot generate
		* midnight datetime, so jump to 1AM, otherwise reset.
		* @param  date  (Date) the date to check
		* @return  (Date) the corrected date
		*/
		_daylightSavingAdjust: function( date ) {
			if ( !date ) {
				return null;
			}
			date.setHours( date.getHours() > 12 ? date.getHours() + 2 : 0 );
			return date;
		},
		Test: function (y, m, d){
			return "<HR>Date:"+y + m + d+"<BR>"+
			TC.tamilDate(y, m, d)+
						"/"+TC.getTamilMonthName(y, m, d)+
						"/"+TC.tamilYear(y, m, d)+
						"/"+TC.getTamilYearName(y, m, d)+
						"/"+TC.getTamilSeason();
		}
		
	}