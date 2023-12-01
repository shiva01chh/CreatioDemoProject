﻿Terrasoft.configuration.Structures["RawConverter"] = {innerHierarchyStack: ["RawConverter"]};
// jscs:disable
/* jshint ignore:start */
/*ignore jslint start*/
define("RawConverter",function(){function t(t){this.type=t,this.state=t+"_LINE",this.info={headers:[],upgrade:!1},this.trailers=[],this.line="",this.isChunked=!1,this.connection="",this.headerSize=0,this.body_bytes=Number.MAX_VALUE,this.isUserCall=!1,this.hadError=!1}t.maxHeaderSize=81920,t.REQUEST="REQUEST",t.RESPONSE="RESPONSE";var e=t.kOnHeaders=0,s=t.kOnHeadersComplete=1,i=t.kOnBody=2,o=t.kOnMessageComplete=3;t.prototype[e]=t.prototype[s]=t.prototype[i]=t.prototype[o]=function(){};var r=!0;Object.defineProperty(t,"kOnExecute",{get:function(){return r=!1,4}});var n=t.methods=["DELETE","GET","HEAD","POST","PUT","CONNECT","OPTIONS","TRACE","COPY","LOCK","MKCOL","MOVE","PROPFIND","PROPPATCH","SEARCH","UNLOCK","BIND","REBIND","UNBIND","ACL","REPORT","MKACTIVITY","CHECKOUT","MERGE","M-SEARCH","NOTIFY","SUBSCRIBE","UNSUBSCRIBE","PATCH","PURGE","MKCALENDAR","LINK","UNLINK"],h=n.indexOf("CONNECT");t.prototype.reinitialize=t,t.prototype.close=t.prototype.pause=t.prototype.resume=t.prototype.free=function(){},t.prototype._compatMode0_11=!1,t.prototype.getAsyncId=function(){return 0};var a={REQUEST_LINE:!0,RESPONSE_LINE:!0,HEADER:!0};t.prototype.execute=function(e,s,i){if(!(this instanceof t))throw new TypeError("not a HTTPParser");s=s||0,i="number"==typeof i?i:e.length,this.chunk=e,this.offset=s;var o=this.end=s+i;try{for(;this.offset<o&&!this[this.state](););}catch(t){if(this.isUserCall)throw t;return this.hadError=!0,t}return this.chunk=null,i=this.offset-s,a[this.state]&&(this.headerSize+=i,this.headerSize>t.maxHeaderSize)?new Error("max header size exceeded"):i};var f={REQUEST_LINE:!0,RESPONSE_LINE:!0,BODY_RAW:!0};t.prototype.finish=function(){if(!this.hadError)return f[this.state]?void("BODY_RAW"===this.state&&this.userCall()(this[o]())):new Error("invalid state for EOF")},t.prototype.consume=t.prototype.unconsume=t.prototype.getCurrentBuffer=function(){},t.prototype.userCall=function(){this.isUserCall=!0;var t=this;return function(e){return t.isUserCall=!1,e}},t.prototype.nextRequest=function(){this.userCall()(this[o]()),this.reinitialize(this.type)},t.prototype.consumeLine=function(){for(var t=this.end,e=this.chunk,s=this.offset;s<t;s++)if(10===e[s]){var i=this.line+e.toString("ascii",this.offset,s);return"\r"===i.charAt(i.length-1)&&(i=i.substr(0,i.length-1)),this.line="",this.offset=s+1,i}this.line+=e.toString("ascii",this.offset,this.end),this.offset=this.end};var u=/^([^: \t]+):[ \t]*((?:.*[^ \t])|)/,d=/^[ \t]+(.*[^ \t])/;t.prototype.parseHeader=function(t,e){if(-1!==t.indexOf("\r"))throw c("HPE_LF_EXPECTED");var s=u.exec(t),i=s&&s[1];if(i)e.push(i),e.push(s[2]);else{var o=d.exec(t);o&&e.length&&(e[e.length-1]&&(e[e.length-1]+=" "),e[e.length-1]+=o[1])}};var E=/^([A-Z-]+) ([^ ]+) HTTP\/(\d)\.(\d)$/;t.prototype.REQUEST_LINE=function(){var t=this.consumeLine();if(t){var e=E.exec(t);if(null===e)throw c("HPE_INVALID_CONSTANT");if(this.info.method=this._compatMode0_11?e[1]:n.indexOf(e[1]),-1===this.info.method)throw new Error("invalid request method");this.info.url=e[2],this.info.versionMajor=+e[3],this.info.versionMinor=+e[4],this.body_bytes=Number.MAX_VALUE,this.state="HEADER"}};var p=/^HTTP\/(\d)\.(\d) (\d{3}) ?(.*)$/;function c(t){var e=new Error("Parse Error");return e.code=t,e}return t.prototype.RESPONSE_LINE=function(){var t=this.consumeLine();if(t){var e=p.exec(t);if(null===e)throw c("HPE_INVALID_CONSTANT");this.info.versionMajor=+e[1],this.info.versionMinor=+e[2];var s=this.info.statusCode=+e[3];this.info.statusMessage=e[4],1!=(s/100|0)&&204!==s&&304!==s||(this.body_bytes=0),this.state="HEADER"}},t.prototype.shouldKeepAlive=function(){if(this.info.versionMajor>0&&this.info.versionMinor>0){if(-1!==this.connection.indexOf("close"))return!1}else if(-1===this.connection.indexOf("keep-alive"))return!1;return!(null===this.body_bytes&&!this.isChunked)},t.prototype.HEADER=function(){var e=this.consumeLine();if(void 0!==e){var i=this.info;if(e)this.parseHeader(e,i.headers);else{for(var o,n,a=i.headers,f=!1,u=!1,d=0;d<a.length;d+=2)switch(a[d].toLowerCase()){case"transfer-encoding":break;case"content-length":if(o=+a[d+1],f){if(o!==this.body_bytes)throw c("HPE_UNEXPECTED_CONTENT_LENGTH")}else f=!0,this.body_bytes=o;break;case"connection":this.connection+=a[d+1].toLowerCase();break;case"upgrade":u=!0}if(this.isChunked&&f)throw c("HPE_UNEXPECTED_CONTENT_LENGTH");if(u&&-1!=this.connection.indexOf("upgrade")?i.upgrade=this.type===t.REQUEST||101===i.statusCode:i.upgrade=i.method===h,i.shouldKeepAlive=this.shouldKeepAlive(),2===(n=r?this.userCall()(this[s](i)):this.userCall()(this[s](i.versionMajor,i.versionMinor,i.headers,i.method,i.url,i.statusCode,i.statusMessage,i.upgrade,i.shouldKeepAlive))))return this.nextRequest(),!0;if(this.isChunked&&!n)this.state="BODY_CHUNKHEAD";else{if(n||0===this.body_bytes)return this.nextRequest(),i.upgrade;null===this.body_bytes?this.state="BODY_RAW":this.state="BODY_SIZED"}}}},t.prototype.BODY_CHUNKHEAD=function(){var t=this.consumeLine();void 0!==t&&(this.body_bytes=parseInt(t,16),this.body_bytes?this.state="BODY_CHUNK":this.state="BODY_CHUNKTRAILERS")},t.prototype.BODY_CHUNK=function(){var t=Math.min(this.end-this.offset,this.body_bytes);this.userCall()(this[i](this.chunk,this.offset,t)),this.offset+=t,this.body_bytes-=t,this.body_bytes||(this.state="BODY_CHUNKEMPTYLINE")},t.prototype.BODY_CHUNKEMPTYLINE=function(){void 0!==this.consumeLine()&&(this.state="BODY_CHUNKHEAD")},t.prototype.BODY_CHUNKTRAILERS=function(){var t=this.consumeLine();void 0!==t&&(t?this.parseHeader(t,this.trailers):(this.trailers.length&&this.userCall()(this[e](this.trailers,"")),this.nextRequest()))},t.prototype.BODY_RAW=function(){var t=this.end-this.offset;this.userCall()(this[i](this.chunk,this.offset,t)),this.offset=this.end},t.prototype.BODY_SIZED=function(){var t=Math.min(this.end-this.offset,this.body_bytes);this.userCall()(this[i](this.chunk,this.offset,t)),this.offset+=t,this.body_bytes-=t,this.body_bytes||this.nextRequest()},["Headers","HeadersComplete","Body","MessageComplete"].forEach(function(e){var s=t["kOn"+e];Object.defineProperty(t.prototype,"on"+e,{get:function(){return this[s]},set:function(t){return this._compatMode0_11=!0,h="CONNECT",this[s]=t}})}),t});
