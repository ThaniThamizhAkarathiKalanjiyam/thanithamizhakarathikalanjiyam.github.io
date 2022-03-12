// Production steps of ECMA-262, Edition 6, 22.1.2.1
if (!Array.from) {
  Array.from = (function () {
    var toStr = Object.prototype.toString;
    var isCallable = function (fn) {
      return typeof fn === 'function' || toStr.call(fn) === '[object Function]';
    };
    var toInteger = function (value) {
      var number = Number(value);
      if (isNaN(number)) { return 0; }
      if (number === 0 || !isFinite(number)) { return number; }
      return (number > 0 ? 1 : -1) * Math.floor(Math.abs(number));
    };
    var maxSafeInteger = Math.pow(2, 53) - 1;
    var toLength = function (value) {
      var len = toInteger(value);
      return Math.min(Math.max(len, 0), maxSafeInteger);
    };

    // The length property of the from method is 1.
    return function from(arrayLike/*, mapFn, thisArg */) {
      // 1. Let C be the this value.
      var C = this;

      // 2. Let items be ToObject(arrayLike).
      var items = Object(arrayLike);

      // 3. ReturnIfAbrupt(items).
      if (arrayLike == null) {
        throw new TypeError('Array.from requires an array-like object - not null or undefined');
      }

      // 4. If mapfn is undefined, then let mapping be false.
      var mapFn = arguments.length > 1 ? arguments[1] : void undefined;
      var T;
      if (typeof mapFn !== 'undefined') {
        // 5. else
        // 5. a If IsCallable(mapfn) is false, throw a TypeError exception.
        if (!isCallable(mapFn)) {
          throw new TypeError('Array.from: when provided, the second argument must be a function');
        }

        // 5. b. If thisArg was supplied, let T be thisArg; else let T be undefined.
        if (arguments.length > 2) {
          T = arguments[2];
        }
      }

      // 10. Let lenValue be Get(items, "length").
      // 11. Let len be ToLength(lenValue).
      var len = toLength(items.length);

      // 13. If IsConstructor(C) is true, then
      // 13. a. Let A be the result of calling the [[Construct]] internal method 
      // of C with an argument list containing the single item len.
      // 14. a. Else, Let A be ArrayCreate(len).
      var A = isCallable(C) ? Object(new C(len)) : new Array(len);

      // 16. Let k be 0.
      var k = 0;
      // 17. Repeat, while k < len… (also steps a - h)
      var kValue;
      while (k < len) {
        kValue = items[k];
        if (mapFn) {
          A[k] = typeof T === 'undefined' ? mapFn(kValue, k) : mapFn.call(T, kValue, k);
        } else {
          A[k] = kValue;
        }
        k += 1;
      }
      // 18. Let putStatus be Put(A, "length", len, true).
      A.length = len;
      // 20. Return A.
      return A;
    };
  }());
}

// some of code resused from Open Tamil.
var version = 0.1; 
var PYTHON3 = version > '3';
// constants;
var TA_ACCENT_LEN = 13 ;
//12 + 1;
var TA_AYUDHA_LEN = 1;
var TA_UYIR_LEN = 12;
var TA_MEI_LEN = 18;
var TA_AGARAM_LEN = 18;
var TA_SANSKRIT_LEN = 6;
var TA_UYIRMEI_LEN = 216;
var TA_GRANTHA_UYIRMEI_LEN = 24*12;
var TA_LETTERS_LEN = 247 + 6*12 + 22 + 4 - TA_AGARAM_LEN - 4 ;

var uyir_letters = ["அ","ஆ","இ","ஈ","உ","ஊ","எ","ஏ","ஐ","ஒ","ஓ","ஔ"];

var ayudha_letter = "ஃ";
var kuril_letters = ["அ", "இ", "உ", "எ", "ஒ"];
var nedil_letters = ["ஆ", "ஈ", "ஊ", "ஏ", "ஓ"];
var vallinam_letters = ["க்", "ச்", "ட்", "த்", "ப்", "ற்"];
var mellinam_letters = ["ங்", "ஞ்", "ண்", "ந்", "ம்", "ன்"];
var idayinam_letters = ["ய்", "ர்", "ல்", "வ்", "ழ்", "ள்"];
var mei_letters = ["க்","ச்","ட்","த்","ப்","ற்",
           "ஞ்","ங்","ண்","ந்","ம்","ன்",
           "ய்","ர்","ல்","வ்","ழ்","ள்" ];
var accent_symbols = ["","ா","ி","ீ","ு","ூ",
          "ெ","ே","ை","ொ","ோ","ௌ","ஃ"];
var pulli_symbols = ["்"];
var agaram_letters = ["க","ச","ட","த","ப","ற",
          "ஞ","ங","ண","ந","ம","ன",
          "ய","ர","ல","வ","ழ","ள"];
var sanskrit_letters = ["ஶ","ஜ","ஷ", "ஸ","ஹ","க்ஷ"];
var sanskrit_mei_letters =["ஶ்","ஜ்","ஷ்", "ஸ்","ஹ்","க்ஷ்"];




var uyirmei_letters = [
"க"  ,"கா"  ,"கி"  ,"கீ"  ,"கு"  ,"கூ"  ,"கெ"  ,"கே"  ,"கை"  ,"கொ"  ,"கோ"  ,"கௌ"  ,
"ச"  ,"சா"  ,"சி"  ,"சீ"  ,"சு"  ,"சூ"  ,"செ"  ,"சே"  ,"சை"  ,"சொ"  ,"சோ"  ,"சௌ" ,
"ட"  ,"டா"  ,"டி"  ,"டீ"  ,"டு"  ,"டூ"  ,"டெ"  ,"டே"  ,"டை"  ,"டொ"  ,"டோ"  ,"டௌ",
"த"  ,"தா"  ,"தி"  ,"தீ"  ,"து"  ,"தூ"  ,"தெ"  ,"தே"  ,"தை"  ,"தொ"  ,"தோ"  ,"தௌ",
"ப"  ,"பா"  ,"பி"  ,"பீ"  ,"பு"  ,"பூ"  ,"பெ"  ,"பே"  ,"பை"  ,"பொ"  ,"போ"  ,"பௌ" ,
"ற"  ,"றா"  ,"றி"  ,"றீ"  ,"று"  ,"றூ"  ,"றெ"  ,"றே"  ,"றை"  ,"றொ"  ,"றோ"  ,"றௌ",
"ஞ"  ,"ஞா"  ,"ஞி"  ,"ஞீ"  ,"ஞு"  ,"ஞூ"  ,"ஞெ"  ,"ஞே"  ,"ஞை"  ,"ஞொ"  ,"ஞோ"  ,"ஞௌ"  ,
"ங"  ,"ஙா"  ,"ஙி"  ,"ஙீ"  ,"ஙு"  ,"ஙூ"  ,"ஙெ"  ,"ஙே"  ,"ஙை"  ,"ஙொ"  ,"ஙோ"  ,"ஙௌ"  ,
"ண"  ,"ணா"  ,"ணி"  ,"ணீ"  ,"ணு"  ,"ணூ"  ,"ணெ"  ,"ணே"  ,"ணை"  ,"ணொ"  ,"ணோ"  ,"ணௌ"  ,
"ந"  ,"நா"  ,"நி"  ,"நீ"  ,"நு"  ,"நூ"  ,"நெ"  ,"நே"  ,"நை"  ,"நொ"  ,"நோ"  ,"நௌ"  ,
"ம"  ,"மா"  ,"மி"  ,"மீ"  ,"மு"  ,"மூ"  ,"மெ"  ,"மே"  ,"மை"  ,"மொ"  ,"மோ"  ,"மௌ" ,
"ன"  ,"னா"  ,"னி"  ,"னீ"  ,"னு"  ,"னூ"  ,"னெ"  ,"னே"  ,"னை"  ,"னொ"  ,"னோ"  ,"னௌ",
"ய"  ,"யா"  ,"யி"  ,"யீ"  ,"யு"  ,"யூ"  ,"யெ"  ,"யே"  ,"யை"  ,"யொ"  ,"யோ"  ,"யௌ",
"ர"  ,"ரா"  ,"ரி"  ,"ரீ"  ,"ரு"  ,"ரூ"  ,"ரெ"  ,"ரே"  ,"ரை"  ,"ரொ"  ,"ரோ"  ,"ரௌ",
"ல"  ,"லா"  ,"லி"  ,"லீ"  ,"லு"  ,"லூ"  ,"லெ"  ,"லே"  ,"லை"  ,"லொ"  ,"லோ"  ,"லௌ" ,
"வ"  ,"வா"  ,"வி"  ,"வீ"  ,"வு"  ,"வூ"  ,"வெ"  ,"வே"  ,"வை"  ,"வொ"  ,"வோ"  ,"வௌ" ,
"ழ"  ,"ழா"  ,"ழி"  ,"ழீ"  ,"ழு"  ,"ழூ"  ,"ழெ"  ,"ழே"  ,"ழை"  ,"ழொ"  ,"ழோ"  ,"ழௌ" ,
"ள"  ,"ளா"  ,"ளி"  ,"ளீ"  ,"ளு"  ,"ளூ"  ,"ளெ"  ,"ளே"  ,"ளை"  ,"ளொ"  ,"ளோ"  ,"ளௌ" ];
// Ref: https:;
//en.wikipedia.org/wiki/Tamil_numerals;
// tamil digits : Apart from the numerals (0-9), Tamil also has numerals for 10, 100 and 1000.;
var tamil_digit_1to10 = ["௦", "௧", "௨","௩","௪","௫","௬","௭","௮","௯","௰"];
var tamil_digit_100 = "௱";
var tamil_digit_1000 = "௲";
// tamil symbols;
var _day = "௳";
var _month = "௴";
var _year = "௵";
var _debit = "௶";
var _credit = "௷";
var _rupee = "௹";
var _numeral = "௺";
var _sri = "\u0bb6\u0bcd\u0bb0\u0bc0" ;
//SRI - ஶ்ரீ;
var _ksha = "\u0b95\u0bcd\u0bb7" ;
//KSHA - க்ஷ;
var _ksh = "\u0b95\u0bcd\u0bb7\u0bcd" ;
//KSH - க்ஷ்;
var tamil_symbols = [_day, _month, _year, _debit, _credit, _rupee, _numeral, _sri, _ksha, _ksh];
// total tamil letters in use, including sanskrit letters;
var tamil_letters = [
// /* Uyir */;
"அ","ஆ","இ", "ஈ","உ","ஊ","எ","ஏ","ஐ","ஒ","ஓ","ஔ",
///* Ayuda Ezhuthu */;
"ஃ",
// /* Mei */;
"க்","ச்","ட்","த்","ப்","ற்","ஞ்","ங்","ண்","ந்","ம்","ன்","ய்","ர்","ல்","வ்","ழ்","ள்",
// /* Agaram */;
// "க","ச","ட","த","ப","ற","ஞ","ங","ண","ந","ம","ன","ய","ர","ல","வ","ழ","ள",
// /* Sanskrit (Vada Mozhi) */;
// "ஜ","ஷ", "ஸ","ஹ",
///* Sanskrit (Mei) */;
"ஜ்","ஷ்", "ஸ்","ஹ்",
// /* Uyir Mei */;
"க"  ,"கா"  ,"கி"  ,"கீ"  ,"கு"  ,"கூ"  ,"கெ"  ,"கே"  ,"கை"  ,"கொ"  ,"கோ"  ,"கௌ"
,"ச"  ,"சா"  ,"சி"  ,"சீ"  ,"சு"  ,"சூ"  ,"செ"  ,"சே"  ,"சை"  ,"சொ"  ,"சோ"  ,"சௌ"
,"ட"  ,"டா"  ,"டி"  ,"டீ"  ,"டு"  ,"டூ"  ,"டெ"  ,"டே"  ,"டை"  ,"டொ"  ,"டோ"  ,"டௌ"
,"த"  ,"தா"  ,"தி"  ,"தீ"  ,"து"  ,"தூ"  ,"தெ"  ,"தே"  ,"தை"  ,"தொ"  ,"தோ"  ,"தௌ"
,"ப"  ,"பா"  ,"பி"  ,"பீ"  ,"பு"  ,"பூ"  ,"பெ"  ,"பே"  ,"பை"  ,"பொ"  ,"போ"  ,"பௌ"
,"ற"  ,"றா"  ,"றி"  ,"றீ"  ,"று"  ,"றூ"  ,"றெ"  ,"றே"  ,"றை"  ,"றொ"  ,"றோ"  ,"றௌ"
,"ஞ"  ,"ஞா"  ,"ஞி"  ,"ஞீ"  ,"ஞு"  ,"ஞூ"  ,"ஞெ"  ,"ஞே"  ,"ஞை"  ,"ஞொ"  ,"ஞோ"  ,"ஞௌ"
,"ங"  ,"ஙா"  ,"ஙி"  ,"ஙீ"  ,"ஙு"  ,"ஙூ"  ,"ஙெ"  ,"ஙே"  ,"ஙை"  ,"ஙொ"  ,"ஙோ"  ,"ஙௌ"
,"ண"  ,"ணா"  ,"ணி"  ,"ணீ"  ,"ணு"  ,"ணூ"  ,"ணெ"  ,"ணே"  ,"ணை"  ,"ணொ"  ,"ணோ"  ,"ணௌ"
,"ந"  ,"நா"  ,"நி"  ,"நீ"  ,"நு"  ,"நூ"  ,"நெ"  ,"நே"  ,"நை"  ,"நொ"  ,"நோ"  ,"நௌ"
,"ம"  ,"மா"  ,"மி"  ,"மீ"  ,"மு"  ,"மூ"  ,"மெ"  ,"மே"  ,"மை"  ,"மொ"  ,"மோ"  ,"மௌ"
,"ன"  ,"னா"  ,"னி"  ,"னீ"  ,"னு"  ,"னூ"  ,"னெ"  ,"னே"  ,"னை"  ,"னொ"  ,"னோ"  ,"னௌ"
,"ய"  ,"யா"  ,"யி"  ,"யீ"  ,"யு"  ,"யூ"  ,"யெ"  ,"யே"  ,"யை"  ,"யொ"  ,"யோ"  ,"யௌ"
,"ர"  ,"ரா"  ,"ரி"  ,"ரீ"  ,"ரு"  ,"ரூ"  ,"ரெ"  ,"ரே"  ,"ரை"  ,"ரொ"  ,"ரோ"  ,"ரௌ"
,"ல"  ,"லா"  ,"லி"  ,"லீ"  ,"லு"  ,"லூ"  ,"லெ"  ,"லே"  ,"லை"  ,"லொ"  ,"லோ"  ,"லௌ"
,"வ"  ,"வா"  ,"வி"  ,"வீ"  ,"வு"  ,"வூ"  ,"வெ"  ,"வே"  ,"வை"  ,"வொ"  ,"வோ"  ,"வௌ"
,"ழ"  ,"ழா"  ,"ழி"  ,"ழீ"  ,"ழு"  ,"ழூ"  ,"ழெ"  ,"ழே"  ,"ழை"  ,"ழொ"  ,"ழோ"  ,"ழௌ"
,"ள"  ,"ளா"  ,"ளி"  ,"ளீ"  ,"ளு"  ,"ளூ"  ,"ளெ"  ,"ளே"  ,"ளை"  ,"ளொ"  ,"ளோ"  ,"ளௌ"
///* Sanskrit Uyir-Mei */;
,"ஶ", 	"ஶா", 	"ஶி", 	"ஶீ", "ஶு", "ஶூ", "ஶெ", "ஶே", "ஶை", "ஶொ", "ஶோ", "ஶௌ"
,"ஜ"  ,"ஜா"  ,"ஜி"  ,"ஜீ"  ,"ஜு"  ,"ஜூ"  ,"ஜெ"  ,"ஜே"  ,"ஜை"  ,"ஜொ"  ,"ஜோ"  ,"ஜௌ"
,"ஷ"  ,"ஷா"  ,"ஷி"  ,"ஷீ"  ,"ஷு"  ,"ஷூ"  ,"ஷெ"  ,"ஷே"  ,"ஷை"  ,"ஷொ"  ,"ஷோ"  ,"ஷௌ"
,"ஸ"  ,"ஸா"  ,"ஸி"  ,"ஸீ"  ,"ஸு"  ,"ஸூ"  ,"ஸெ"  ,"ஸே"  ,"ஸை"  ,"ஸொ"  ,"ஸோ"  ,"ஸௌ"
,"ஹ"  ,"ஹா"  ,"ஹி"  ,"ஹீ"  ,"ஹு"  ,"ஹூ"  ,"ஹெ"  ,"ஹே"  ,"ஹை"  ,"ஹொ"  ,"ஹோ"  ,"ஹௌ"
,"க்ஷ"  ,"க்ஷா"  ,"க்ஷி" 	,"க்ஷீ" 	,"க்ஷு"  ,"க்ஷூ"  ,"க்ஷெ"   ,"க்ஷே" ,"க்ஷை"  ,"க்ஷொ" ,"க்ஷோ"  ,"க்ஷௌ",
"ஸ்ரீ" ];

var grantha_agaram_letters = Array.from(agaram_letters);
grantha_agaram_letters = grantha_agaram_letters.concat(sanskrit_letters);

var grantha_agaram_set = Array.from(grantha_agaram_letters);
var accent_symbol_set = Array.from(accent_symbols);
var uyir_letter_set   = Array.from(uyir_letters);

function get_tamil_letters( word ){
    // splits the word into a character-list of tamil/english;
    //characters present in the stream "";

    ta_letters = [];
    not_empty = false;
    WLEN = word.length;
	idx = 0;
	
	//alert (uyir_letter_set);
	
	try
	{
	
    while (idx < WLEN){
        c = word[idx];
        ;
//print(idx,hex(ascii(c)),len(ta_letters));
        if ( uyir_letter_set.indexOf(c) >= 0 || c == ayudha_letter){
            ta_letters = ta_letters.concat( c );
            not_empty = true;
		}
        else if ( grantha_agaram_set.indexOf(c) >= 0)
		{
            ta_letters = ta_letters.concat( c );
            not_empty = true;
		}
        else if (accent_symbol_set.indexOf(c) >= 0 ){
            if (!not_empty){
                ;
// odd situation;
                ta_letters = ta_letters.concat( c );
                not_empty = true;
				}
            else{
                ;		
				//print("Merge/accent");
				//ta_letters[-1] += c;
                ta_letters[ta_letters.length-1] += c;				
			}
		}
        else{
            if (c.charCodeAt(0) < 256){
                ta_letters = ta_letters.concat( c );
			}
            else{
                if (not_empty){
                    ;
					//print("Merge/??");
                    //ta_letters[-1] += c;
					ta_letters[ta_letters.length-1] += c;				
				}
                else{
                    ta_letters = ta_letters.concat(c);
                    not_empty = true;
				}
			}
		}
        idx = idx + 1;
	}
	}
	catch(err)
	{
		alert(err.message);
		
	}
    return ta_letters;
}

function kirantham_nekki_thanithamizh(inputWord_ta)
{
	//To use this fuction you should import vadam.tamil.pairs.js
	//into your head tag. then only able to use
		
	var thani_thamizh_word = "";
	
	if(vadam_tamil != null)
	{	
		var givenWords_ta = inputWord_ta.split(" ");
		

		for(wrdsCount_ta = 0; wrdsCount_ta < givenWords_ta.length; wrdsCount_ta++)
		{
			var tamil_word = vadam_tamil[givenWords_ta[wrdsCount_ta]];
			
			if(tamil_word != null)
			{
				thani_thamizh_word += tamil_word + " (" + givenWords_ta[wrdsCount_ta] + ") ";				
			}
			else
			{
				thani_thamizh_word += kirantham_nekki(givenWords_ta[wrdsCount_ta]);
			}
		}		
		//thani_thamizh_word = vadam_tamil['அனுமதி']
		//alert(thani_thamizh_word);
	}
	return thani_thamizh_word;
}
//function removeSpecialChars(strVal)
//{
//strVal = strVal.replace(/[^a-zA-Z 0-9]+/g,”);
//}
function kirantham_nekki(inputWord)
{
	var givenWords = inputWord.split(" ");
	var theWholeWord = "";
	
	for(wrdsCount = 0; wrdsCount < givenWords.length; wrdsCount++)
	{
	
	word = givenWords[wrdsCount].replace("ஸ்ரீ", "திரு").replace("க்ஷூ","கீ");		
			
	var _ta_letters = get_tamil_letters( word );
	
	
		for(i =0; i < _ta_letters.length; i++)
		{
			if(i == 0)
			{
				//First character-list
				_ta_letters[i] = _ta_letters[i].replace("ஷ","ச");	
				_ta_letters[i] = _ta_letters[i].replace("ஜ","ச");	
				_ta_letters[i] = _ta_letters[i].replace("ர்","இ");
				_ta_letters[i] = _ta_letters[i].replace("ர","இர");
				_ta_letters[i] = _ta_letters[i].replace("ல","இல");
				_ta_letters[i] = _ta_letters[i].replace("ய","இய");
				if (_ta_letters[i] == ("ஹௌ"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹௌ", "ஔ");
				}
				else if (_ta_letters[i] == ("ஹோ"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹோ", "ஓ");
				}
				else if (_ta_letters[i] == ("ஹொ"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹொ", "ஒ");
				}
				else if (_ta_letters[i] == ("ஹை"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹை", "ஐ");
				}
				else if (_ta_letters[i] == ("ஹே"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹே", "ஏ");
				}
				else if (_ta_letters[i] == ("ஹே"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹே", "எ");
				}
				else if (_ta_letters[i] == ("ஹூ"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹூ", "ஊ");
				}
				else if (_ta_letters[i] == ("ஹு"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹு", "உ");
				}
				else if (_ta_letters[i] == ("ஹீ"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹீ", "ஈ");
				}
				else if (_ta_letters[i] == ("ஹி"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹி", "இ");
				}
				else if (_ta_letters[i] == ("ஹா"))
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹா", "ஆ");
				}
				else
				{
					_ta_letters[i] = _ta_letters[i].replace("ஹ","அ");
				}
				_ta_letters[i] = _ta_letters[i].replace("க்ஷ", "க")			
			}
			else if(i == (_ta_letters.length - 1))
			{
				//lastCharList
				if(_ta_letters[i].indexOf("ஷ்") >= 0 ||
				_ta_letters[i].indexOf("ஸ்") >= 0
				)
				{
					_ta_letters[i] = _ta_letters[i].replace("ஷ்","சு");
					_ta_letters[i] = _ta_letters[i].replace("ஸ்","சு"); //அமிருதசரஸ்
				}
				else if(_ta_letters[i].indexOf("ஷ") >= 0 ||
				_ta_letters[i].indexOf("ஸ") >= 0 ||
				_ta_letters[i].indexOf("ஜ") >= 0
				)
				{
					_ta_letters[i] = _ta_letters[i].replace("ஷ","ச/ய");	
					_ta_letters[i] = _ta_letters[i].replace("ஸ","ச/த");			
					_ta_letters[i] = _ta_letters[i].replace("ஜ","ச");
				}
				else
				{
					_ta_letters[i] = _ta_letters[i].replace("ா","ை");
				}
			}
			else
			{
				//middle characters
				if(_ta_letters[i].indexOf("க்ஷ்") >= 0)
				{
					_ta_letters[i] = _ta_letters[i].replace("க்ஷ்","க்கு");
				}
				else if(_ta_letters[i].indexOf("ஷ்") >= 0)
				{
					_ta_letters[i] = _ta_letters[i].replace("ஷ்","ட்");
				}
				else 
				{
					_ta_letters[i] = _ta_letters[i].replace("ஷ","ச/ய");			
					_ta_letters[i] = _ta_letters[i].replace("க்ஷ", "க்க")	
					_ta_letters[i] = _ta_letters[i].replace("ஸ","ச/த");
					_ta_letters[i] = _ta_letters[i].replace("ஜ","ச");
				}
			}
		}	
	
		for(i =0; i < _ta_letters.length; i++)
		{
			//For all common letters
			_ta_letters[i] = _ta_letters[i].replace("ஹ","க");
			_ta_letters[i] = _ta_letters[i].replace("ஸ","ச");
			_ta_letters[i] = _ta_letters[i].replace("ஜ","ய");
		}
	
		pureTaWord = "";
	
		for(i =0; i < _ta_letters.length; i++)
		{
			//For all common letters
			pureTaWord += _ta_letters[i];
		}
	
		pureTaWord = pureTaWord.replace("க்ல", "க்கில")
			.replace("க்ர", "க்கிர")			
			.replace("்வ", "ுவ");
			//.replace("்ம", "ும")
			
		if(word == pureTaWord)
		{
			theWholeWord += pureTaWord + " ";
		}
		else
		{
			theWholeWord += pureTaWord + " ("+word+") ";
		}
	}
	
	return theWholeWord;
}