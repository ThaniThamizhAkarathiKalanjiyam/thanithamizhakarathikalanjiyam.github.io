function sprintf(){var regex=/%%|%(\d+\$)?([-+\'#0 ]*)(\*\d+\$|\*|\d+)?(\.(\*\d+\$|\*|\d+))?([scboxXuidfegEG])/g;var a=arguments,i=0,format=a[i++];var pad=function(str,len,chr,leftJustify){if(!chr){chr=' ';}
var padding=(str.length>=len)?'':Array(1+len-str.length>>>0).join(chr);return leftJustify?str+padding:padding+str;};var justify=function(value,prefix,leftJustify,minWidth,zeroPad,customPadChar){var diff=minWidth-value.length;if(diff>0){if(leftJustify||!zeroPad){value=pad(value,minWidth,customPadChar,leftJustify);}else{value=value.slice(0,prefix.length)+pad('',diff,'0',true)+value.slice(prefix.length);}}
return value;};var formatBaseX=function(value,base,prefix,leftJustify,minWidth,precision,zeroPad){var number=value>>>0;prefix=prefix&&number&&{'2':'0b','8':'0','16':'0x'}[base]||'';value=prefix+pad(number.toString(base),precision||0,'0',false);return justify(value,prefix,leftJustify,minWidth,zeroPad);};var formatString=function(value,leftJustify,minWidth,precision,zeroPad,customPadChar){if(precision!=null){value=value.slice(0,precision);}
return justify(value,'',leftJustify,minWidth,zeroPad,customPadChar);};var doFormat=function(substring,valueIndex,flags,minWidth,_,precision,type){var number;var prefix;var method;var textTransform;var value;if(substring=='%%'){return'%';}
var leftJustify=false,positivePrefix='',zeroPad=false,prefixBaseX=false,customPadChar=' ';var flagsl=flags.length;for(var j=0;flags&&j<flagsl;j++){switch(flags.charAt(j)){case' ':positivePrefix=' ';break;case'+':positivePrefix='+';break;case'-':leftJustify=true;break;case"'":customPadChar=flags.charAt(j+1);break;case'0':zeroPad=true;break;case'#':prefixBaseX=true;break;}}
if(!minWidth){minWidth=0;}else if(minWidth=='*'){minWidth=+a[i++];}else if(minWidth.charAt(0)=='*'){minWidth=+a[minWidth.slice(1,-1)];}else{minWidth=+minWidth;}
if(minWidth<0){minWidth=-minWidth;leftJustify=true;}
if(!isFinite(minWidth)){throw new Error('sprintf: (minimum-)width must be finite');}
if(!precision){precision='fFeE'.indexOf(type)>-1?6:(type=='d')?0:undefined;}else if(precision=='*'){precision=+a[i++];}else if(precision.charAt(0)=='*'){precision=+a[precision.slice(1,-1)];}else{precision=+precision;}
value=valueIndex?a[valueIndex.slice(0,-1)]:a[i++];switch(type){case's':return formatString(String(value),leftJustify,minWidth,precision,zeroPad,customPadChar);case'c':return formatString(String.fromCharCode(+value),leftJustify,minWidth,precision,zeroPad);case'b':return formatBaseX(value,2,prefixBaseX,leftJustify,minWidth,precision,zeroPad);case'o':return formatBaseX(value,8,prefixBaseX,leftJustify,minWidth,precision,zeroPad);case'x':return formatBaseX(value,16,prefixBaseX,leftJustify,minWidth,precision,zeroPad);case'X':return formatBaseX(value,16,prefixBaseX,leftJustify,minWidth,precision,zeroPad).toUpperCase();case'u':return formatBaseX(value,10,prefixBaseX,leftJustify,minWidth,precision,zeroPad);case'i':case'd':number=(+value)|0;prefix=number<0?'-':positivePrefix;value=prefix+pad(String(Math.abs(number)),precision,'0',false);return justify(value,prefix,leftJustify,minWidth,zeroPad);case'e':case'E':case'f':case'F':case'g':case'G':number=+value;prefix=number<0?'-':positivePrefix;method=['toExponential','toFixed','toPrecision']['efg'.indexOf(type.toLowerCase())];textTransform=['toString','toUpperCase']['eEfFgG'.indexOf(type)%2];value=prefix+Math.abs(number)[method](precision);return justify(value,prefix,leftJustify,minWidth,zeroPad)[textTransform]();default:return substring;}};return format.replace(regex,doFormat);};/* Pure Javascript implementation of Uniforum message translation.
Copyright (C) 2008 Joshua I. Miller <unrtst@cpan.org>, all rights reserved
Licensed under GPLv2 : https://www.gnu.org/licenses/gpl-2.0.html
Source at : https://metacpan.org/pod/Locale::Simple */
Gettext=function(args){this.domain='messages';this.locale_data=undefined;var options=["domain","locale_data"];if(this.isValidObject(args)){for(var i in args){for(var j=0;j<options.length;j++){if(i==options[j]){if(this.isValidObject(args[i]))
this[i]=args[i];}}}}
this.try_load_lang();return this;}
Gettext.context_glue="\004";Gettext._locale_data={};Gettext.prototype.try_load_lang=function(){if(typeof(this.locale_data)!='undefined'){var locale_copy=this.locale_data;this.locale_data=undefined;this.parse_locale_data(locale_copy);if(typeof(Gettext._locale_data[this.domain])=='undefined'){throw new Error("Error: Gettext 'locale_data' does not contain the domain '"+this.domain+"'");}}
var lang_link=this.get_lang_refs();if(typeof(lang_link)=='object'&&lang_link.length>0){for(var i=0;i<lang_link.length;i++){var link=lang_link[i];if(link.type=='application/json'){if(!this.try_load_lang_json(link.href)){throw new Error("Error: Gettext 'try_load_lang_json' failed. Unable to exec xmlhttprequest for link ["+link.href+"]");}}else if(link.type=='application/x-po'){if(!this.try_load_lang_po(link.href)){throw new Error("Error: Gettext 'try_load_lang_po' failed. Unable to exec xmlhttprequest for link ["+link.href+"]");}}else{throw new Error("TODO: link type ["+link.type+"] found, and support is planned, but not implemented at this time.");}}}};Gettext.prototype.parse_locale_data=function(locale_data){if(typeof(Gettext._locale_data)=='undefined'){Gettext._locale_data={};}
for(var domain in locale_data){if((!locale_data.hasOwnProperty(domain))||(!this.isValidObject(locale_data[domain])))
continue;var has_msgids=false;for(var msgid in locale_data[domain]){has_msgids=true;break;}
if(!has_msgids)continue;var data=locale_data[domain];if(domain=="")domain="messages";if(!this.isValidObject(Gettext._locale_data[domain]))
Gettext._locale_data[domain]={};if(!this.isValidObject(Gettext._locale_data[domain].head))
Gettext._locale_data[domain].head={};if(!this.isValidObject(Gettext._locale_data[domain].msgs))
Gettext._locale_data[domain].msgs={};for(var key in data){if(key==""){var header=data[key];for(var head in header){var h=head.toLowerCase();Gettext._locale_data[domain].head[h]=header[head];}}else{Gettext._locale_data[domain].msgs[key]=data[key];}}}
for(var domain in Gettext._locale_data){if(this.isValidObject(Gettext._locale_data[domain].head['plural-forms'])&&typeof(Gettext._locale_data[domain].head.plural_func)=='undefined'){var plural_forms=Gettext._locale_data[domain].head['plural-forms'];var pf_re=new RegExp('^(\\s*nplurals\\s*=\\s*[0-9]+\\s*;\\s*plural\\s*=\\s*(?:\\s|[-\\?\\|&=!<>+*/%:;a-zA-Z0-9_\(\)])+)','m');if(pf_re.test(plural_forms)){var pf=Gettext._locale_data[domain].head['plural-forms'];if(!/;\s*$/.test(pf))pf=pf.concat(';');var code='var plural; var nplurals; '+pf+' return { "nplural" : nplurals, "plural" : (plural === true ? 1 : plural ? plural : 0) };';Gettext._locale_data[domain].head.plural_func=new Function("n",code);}else{throw new Error("Syntax error in language file. Plural-Forms header is invalid ["+plural_forms+"]");}}else if(typeof(Gettext._locale_data[domain].head.plural_func)=='undefined'){Gettext._locale_data[domain].head.plural_func=function(n){var p=(n!=1)?1:0;return{'nplural':2,'plural':p};};}}
return;};Gettext.prototype.try_load_lang_po=function(uri){var data=this.sjax(uri);if(!data)return;var domain=this.uri_basename(uri);var parsed=this.parse_po(data);var rv={};if(parsed){if(!parsed[""])parsed[""]={};if(!parsed[""]["domain"])parsed[""]["domain"]=domain;domain=parsed[""]["domain"];rv[domain]=parsed;this.parse_locale_data(rv);}
return 1;};Gettext.prototype.uri_basename=function(uri){var rv;if(rv=uri.match(/^(.*\/)?(.*)/)){var ext_strip;if(ext_strip=rv[2].match(/^(.*)\..+$/))
return ext_strip[1];else
return rv[2];}else{return"";}};Gettext.prototype.parse_po=function(data){var rv={};var buffer={};var lastbuffer="";var errors=[];var lines=data.split("\n");for(var i=0;i<lines.length;i++){lines[i]=lines[i].replace(/(\n|\r)+$/,'');var match;if(/^$/.test(lines[i])){if(typeof(buffer['msgid'])!='undefined'){var msg_ctxt_id=(typeof(buffer['msgctxt'])!='undefined'&&buffer['msgctxt'].length)?buffer['msgctxt']+Gettext.context_glue+buffer['msgid']:buffer['msgid'];var msgid_plural=(typeof(buffer['msgid_plural'])!='undefined'&&buffer['msgid_plural'].length)?buffer['msgid_plural']:null;var trans=[];for(var str in buffer){var match;if(match=str.match(/^msgstr_(\d+)/))
trans[parseInt(match[1])]=buffer[str];}
trans.unshift(msgid_plural);if(trans.length>1)rv[msg_ctxt_id]=trans;buffer={};lastbuffer="";}}else if(/^#/.test(lines[i])){continue;}else if(match=lines[i].match(/^msgctxt\s+(.*)/)){lastbuffer='msgctxt';buffer[lastbuffer]=this.parse_po_dequote(match[1]);}else if(match=lines[i].match(/^msgid\s+(.*)/)){lastbuffer='msgid';buffer[lastbuffer]=this.parse_po_dequote(match[1]);}else if(match=lines[i].match(/^msgid_plural\s+(.*)/)){lastbuffer='msgid_plural';buffer[lastbuffer]=this.parse_po_dequote(match[1]);}else if(match=lines[i].match(/^msgstr\s+(.*)/)){lastbuffer='msgstr_0';buffer[lastbuffer]=this.parse_po_dequote(match[1]);}else if(match=lines[i].match(/^msgstr\[0\]\s+(.*)/)){lastbuffer='msgstr_0';buffer[lastbuffer]=this.parse_po_dequote(match[1]);}else if(match=lines[i].match(/^msgstr\[(\d+)\]\s+(.*)/)){lastbuffer='msgstr_'+match[1];buffer[lastbuffer]=this.parse_po_dequote(match[2]);}else if(/^"/.test(lines[i])){buffer[lastbuffer]+=this.parse_po_dequote(lines[i]);}else{errors.push("Strange line ["+i+"] : "+lines[i]);}}
if(typeof(buffer['msgid'])!='undefined'){var msg_ctxt_id=(typeof(buffer['msgctxt'])!='undefined'&&buffer['msgctxt'].length)?buffer['msgctxt']+Gettext.context_glue+buffer['msgid']:buffer['msgid'];var msgid_plural=(typeof(buffer['msgid_plural'])!='undefined'&&buffer['msgid_plural'].length)?buffer['msgid_plural']:null;var trans=[];for(var str in buffer){var match;if(match=str.match(/^msgstr_(\d+)/))
trans[parseInt(match[1])]=buffer[str];}
trans.unshift(msgid_plural);if(trans.length>1)rv[msg_ctxt_id]=trans;buffer={};lastbuffer="";}
if(rv[""]&&rv[""][1]){var cur={};var hlines=rv[""][1].split(/\\n/);for(var i=0;i<hlines.length;i++){if(!hlines.length)continue;var pos=hlines[i].indexOf(':',0);if(pos!=-1){var key=hlines[i].substring(0,pos);var val=hlines[i].substring(pos+1);var keylow=key.toLowerCase();if(cur[keylow]&&cur[keylow].length){errors.push("SKIPPING DUPLICATE HEADER LINE: "+hlines[i]);}else if(/#-#-#-#-#/.test(keylow)){errors.push("SKIPPING ERROR MARKER IN HEADER: "+hlines[i]);}else{val=val.replace(/^\s+/,'');cur[keylow]=val;}}else{errors.push("PROBLEM LINE IN HEADER: "+hlines[i]);cur[hlines[i]]='';}}
rv[""]=cur;}else{rv[""]={};}
return rv;};Gettext.prototype.parse_po_dequote=function(str){var match;if(match=str.match(/^"(.*)"/)){str=match[1];}
str=str.replace(/\\"/g,"\"");return str;};Gettext.prototype.try_load_lang_json=function(uri){var data=this.sjax(uri);if(!data)return;var rv=this.JSON(data);this.parse_locale_data(rv);return 1;};Gettext.prototype.get_lang_refs=function(){var langs=new Array();var links=document.getElementsByTagName("link");for(var i=0;i<links.length;i++){if(links[i].rel=='gettext'&&links[i].href){if(typeof(links[i].type)=='undefined'||links[i].type==''){if(/\.json$/i.test(links[i].href)){links[i].type='application/json';}else if(/\.js$/i.test(links[i].href)){links[i].type='application/json';}else if(/\.po$/i.test(links[i].href)){links[i].type='application/x-po';}else if(/\.mo$/i.test(links[i].href)){links[i].type='application/x-mo';}else{throw new Error("LINK tag with rel=gettext found, but the type and extension are unrecognized.");}}
links[i].type=links[i].type.toLowerCase();if(links[i].type=='application/json'){links[i].type='application/json';}else if(links[i].type=='text/javascript'){links[i].type='application/json';}else if(links[i].type=='application/x-po'){links[i].type='application/x-po';}else if(links[i].type=='application/x-mo'){links[i].type='application/x-mo';}else{throw new Error("LINK tag with rel=gettext found, but the type attribute ["+links[i].type+"] is unrecognized.");}
langs.push(links[i]);}}
return langs;};Gettext.prototype.textdomain=function(domain){if(domain&&domain.length)this.domain=domain;return this.domain;}
Gettext.prototype.gettext=function(msgid){var msgctxt;var msgid_plural;var n;var category;return this.dcnpgettext(null,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dgettext=function(domain,msgid){var msgctxt;var msgid_plural;var n;var category;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dcgettext=function(domain,msgid,category){var msgctxt;var msgid_plural;var n;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.ngettext=function(msgid,msgid_plural,n){var msgctxt;var category;return this.dcnpgettext(null,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dngettext=function(domain,msgid,msgid_plural,n){var msgctxt;var category;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dcngettext=function(domain,msgid,msgid_plural,n,category){var msgctxt;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category,category);};Gettext.prototype.pgettext=function(msgctxt,msgid){var msgid_plural;var n;var category;return this.dcnpgettext(null,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dpgettext=function(domain,msgctxt,msgid){var msgid_plural;var n;var category;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dcpgettext=function(domain,msgctxt,msgid,category){var msgid_plural;var n;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.npgettext=function(msgctxt,msgid,msgid_plural,n){var category;return this.dcnpgettext(null,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dnpgettext=function(domain,msgctxt,msgid,msgid_plural,n){var category;return this.dcnpgettext(domain,msgctxt,msgid,msgid_plural,n,category);};Gettext.prototype.dcnpgettext=function(domain,msgctxt,msgid,msgid_plural,n,category){if(!this.isValidObject(msgid))return'';var plural=this.isValidObject(msgid_plural);var msg_ctxt_id=this.isValidObject(msgctxt)?msgctxt+Gettext.context_glue+msgid:msgid;var domainname=this.isValidObject(domain)?domain:this.isValidObject(this.domain)?this.domain:'messages';var category_name='LC_MESSAGES';var category=5;var locale_data=new Array();if(typeof(Gettext._locale_data)!='undefined'&&this.isValidObject(Gettext._locale_data[domainname])){locale_data.push(Gettext._locale_data[domainname]);}else if(typeof(Gettext._locale_data)!='undefined'){for(var dom in Gettext._locale_data){locale_data.push(Gettext._locale_data[dom]);}}
var trans=[];var found=false;var domain_used;if(locale_data.length){for(var i=0;i<locale_data.length;i++){var locale=locale_data[i];if(this.isValidObject(locale.msgs[msg_ctxt_id])){for(var j=0;j<locale.msgs[msg_ctxt_id].length;j++){trans[j]=locale.msgs[msg_ctxt_id][j];}
trans.shift();domain_used=locale;found=true;if(trans.length>0&&trans[0].length!=0)
break;}}}
if(trans.length==0||trans[0].length==0){trans=[msgid,msgid_plural];}
var translation=trans[0];if(plural){var p;if(found&&this.isValidObject(domain_used.head.plural_func)){var rv=domain_used.head.plural_func(n);if(!rv.plural)rv.plural=0;if(!rv.nplural)rv.nplural=0;if(rv.nplural<=rv.plural)rv.plural=0;p=rv.plural;}else{p=(n!=1)?1:0;}
if(this.isValidObject(trans[p]))
translation=trans[p];}
return translation;};Gettext.strargs=function(str,args){if(null==args||'undefined'==typeof(args)){args=[];}else if(args.constructor!=Array){args=[args];}
var newstr="";while(true){var i=str.indexOf('%');var match_n;if(i==-1){newstr+=str;break;}
newstr+=str.substr(0,i);if(str.substr(i,2)=='%%'){newstr+='%';str=str.substr((i+2));}else if(match_n=str.substr(i).match(/^%(\d+)/)){var arg_n=parseInt(match_n[1]);var length_n=match_n[1].length;if(arg_n>0&&args[arg_n-1]!=null&&typeof(args[arg_n-1])!='undefined')
newstr+=args[arg_n-1];str=str.substr((i+1+length_n));}else{newstr+='%';str=str.substr((i+1));}}
return newstr;}
Gettext.prototype.strargs=function(str,args){return Gettext.strargs(str,args);}
Gettext.prototype.isArray=function(thisObject){return this.isValidObject(thisObject)&&thisObject.constructor==Array;};Gettext.prototype.isValidObject=function(thisObject){if(null==thisObject){return false;}else if('undefined'==typeof(thisObject)){return false;}else{return true;}};Gettext.prototype.sjax=function(uri){var xmlhttp;if(window.XMLHttpRequest){xmlhttp=new XMLHttpRequest();}else if(navigator.userAgent.toLowerCase().indexOf('msie 5')!=-1){xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");}else{xmlhttp=new ActiveXObject("Msxml2.XMLHTTP");}
if(!xmlhttp)
throw new Error("Your browser doesn't do Ajax. Unable to support external language files.");xmlhttp.open('GET',uri,false);try{xmlhttp.send(null);}
catch(e){return;}
var sjax_status=xmlhttp.status;if(sjax_status==200||sjax_status==0){return xmlhttp.responseText;}else{var error=xmlhttp.statusText+" (Error "+xmlhttp.status+")";if(xmlhttp.responseText.length){error+="\n"+xmlhttp.responseText;}
alert(error);return;}}
Gettext.prototype.JSON=function(data){return eval('('+data+')');};if(typeof sprintf!='function'){throw"locale_simple.js: require a javascript sprintf implementation";}
if(typeof Gettext!='function'||typeof Gettext.strargs!='function'){throw"locale_simple.js: require Gettext.js of https://jsgettext.berlios.de/ to be loaded, included in this distribution.";}
if(typeof locale_simple!='undefined'){throw"locale_simple.js: locale_simple.js already loaded";}
var locale_data={};var locale_simple={curr:null,lang:null,dir:null,dry:0,nowrite:0,tds:{},l_dir:function(dir){if(this.dir!=null){throw"locale_simple.js: can't switch dir";}
this.dir=dir;},l_dry:function(dry,nowrite){this.dry=dry;this.nowrite=nowrite;},l_lang:function(lang){if(this.lang!=null){throw"locale_simple.js: can't switch language";}
this.lang=lang;},ltd:function(textdomain){if(!(textdomain in this.tds)){this.tds[textdomain]=new Gettext({'domain':textdomain,'locale_data':locale_data});}
this.curr=this.tds[textdomain];return textdomain;},wd:function(td,msgctxt,msgid,msgid_plural){if(typeof console!='object'){return;}
if(typeof console.debug!='function'){return;}
if(td){console.debug('# domain: '+td)}
if(msgctxt){console.debug('msgctxt "'+msgctxt+'"')}
if(msgid){console.debug('msgid "'+msgid+'"')}
if(msgid_plural){console.debug('msgid_plural "'+msgid_plural+'"')}
console.debug('');},l:function(){var A=this.argarr(arguments);var id=A.shift();var gt;if(this.dry){gt=id;if(!this.nowrite){this.wd(null,null,id,null);}}else{gt=this.curr.gettext(id);}
A.unshift(gt);return sprintf.apply(null,A);},ln:function(){var A=this.argarr(arguments);var id=A.shift();var idp=A.shift();var n=A.shift();var gt;if(this.dry){if(n!=1){gt=idp;}else{gt=id;}
if(!this.nowrite){this.wd(null,null,id,idp);}}else{gt=this.curr.ngettext(id,idp,n);}
A.unshift(n);A.unshift(gt);return sprintf.apply(null,A);},lp:function(){var A=this.argarr(arguments);var ctxt=A.shift();var id=A.shift();var gt;if(this.dry){gt=id;if(!this.nowrite){this.wd(null,ctxt,id,null);}}else{gt=this.curr.pgettext(ctxt,id);}
A.unshift(gt);return sprintf.apply(null,A);},lnp:function(){var A=this.argarr(arguments);var ctxt=A.shift();var id=A.shift();var idp=A.shift();var n=A.shift();var gt;if(this.dry){if(n!=1){gt=idp;}else{gt=id;}
if(!this.nowrite){this.wd(null,ctxt,id,idp);}}else{gt=this.curr.npgettext(ctxt,id,idp,n);}
A.unshift(n);A.unshift(gt);return sprintf.apply(null,A);},ld:function(){var A=this.argarr(arguments);var td=A.shift();var id=A.shift();var gt;if(this.dry){gt=id;if(!this.nowrite){this.wd(td,null,id,null);}}else{gt=this.curr.dgettext(td,id);}
A.unshift(gt);return sprintf.apply(null,A);},ldn:function(){var A=this.argarr(arguments);var td=A.shift();var id=A.shift();var idp=A.shift();var n=A.shift();var gt;if(this.dry){if(n!=1){gt=idp;}else{gt=id;}
if(!this.nowrite){this.wd(td,null,id,idp);}}else{gt=this.curr.dngettext(td,id,idp,n);}
A.unshift(n);A.unshift(gt);return sprintf.apply(null,A);},ldp:function(){var A=this.argarr(arguments);var td=A.shift();var ctxt=A.shift();var id=A.shift();var gt;if(this.dry){gt=id;if(!this.nowrite){this.wd(td,ctxt,id,null);}}else{gt=this.curr.dpgettext(td,ctxt,id);}
A.unshift(gt);return sprintf.apply(null,A);},ldnp:function(){var A=this.argarr(arguments);var td=A.shift();var ctxt=A.shift();var id=A.shift();var idp=A.shift();var n=A.shift();var gt;if(this.dry){if(n!=1){gt=idp;}else{gt=id;}
if(!this.nowrite){this.wd(td,ctxt,id,idp);}}else{gt=this.curr.dnpgettext(td,ctxt,id,idp,n);}
A.unshift(n);A.unshift(gt);return sprintf.apply(null,A);},argarr:function(args){var arr=new Array();for(var i=0,len=args.length;i<len;i++){arr.push(args[i]);}
return arr;}};function l_dry(){return locale_simple.l_dry.apply(locale_simple,arguments)}
function l_dir(){return locale_simple.l_dir.apply(locale_simple,arguments)}
function l_lang(){return locale_simple.l_lang.apply(locale_simple,arguments)}
function ltd(){return locale_simple.ltd.apply(locale_simple,arguments)}
function l(){return locale_simple.l.apply(locale_simple,arguments)}
function ln(){return locale_simple.ln.apply(locale_simple,arguments)}
function lp(){return locale_simple.lp.apply(locale_simple,arguments)}
function lnp(){return locale_simple.lnp.apply(locale_simple,arguments)}
function ld(){return locale_simple.ld.apply(locale_simple,arguments)}
function ldn(){return locale_simple.ldn.apply(locale_simple,arguments)}
function ldp(){return locale_simple.ldp.apply(locale_simple,arguments)}
function ldnp(){return locale_simple.ldnp.apply(locale_simple,arguments)};locale_data['duckduckgo-duckduckgo']={"":{"Plural-Forms":" nplurals=2; plural=n != 1;","MIME-Version":" 1.0","POT-Creation-Date":" 2018-10-19 04:44-0500","Language":" English of United States (English of United States)","Last-Translator":" Community","Content-Type":" text/plain; charset=UTF-8","Language-Team":" DuckDuckGo Community <community@duckduckgo.com>","PO-Revision-Date":" 2018-10-19 04:44-0500","Project-Id-Version":" DuckDuckGo-Translation-0.000","Content-Transfer-Encoding":" 8bit"}};ltd('duckduckgo-duckduckgo');