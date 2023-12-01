﻿Terrasoft.configuration.Structures["RawBase64"] = {innerHierarchyStack: ["RawBase64"]};
// jscs:disable
/* jshint ignore:start */
/*ignore jslint start*/
define("RawBase64",function(){const t={},r=[],e=[],n="undefined"!=typeof Uint8Array?Uint8Array:Array,o="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";for(let t=0,n=o.length;t<n;++t)r[t]=o[t],e[o.charCodeAt(t)]=t;function c(t){const r=t.length;if(r%4>0)throw new Error("Invalid string. Length must be a multiple of 4");return"="===t[r-2]?2:"="===t[r-1]?1:0}function h(t,e,n){for(var o,c,h=[],a=e;a<n;a+=3)o=(t[a]<<16&16711680)+(t[a+1]<<8&65280)+(255&t[a+2]),h.push(r[(c=o)>>18&63]+r[c>>12&63]+r[c>>6&63]+r[63&c]);return h.join("")}return e["-".charCodeAt(0)]=62,e["_".charCodeAt(0)]=63,t.byteLength=function(t){return 3*t.length/4-c(t)},t.toByteArray=function(t){let r,o,h,a,u;const A=t.length;a=c(t),u=new n(3*A/4-a),o=a>0?A-4:A;let d=0;for(r=0;r<o;r+=4)h=e[t.charCodeAt(r)]<<18|e[t.charCodeAt(r+1)]<<12|e[t.charCodeAt(r+2)]<<6|e[t.charCodeAt(r+3)],u[d++]=h>>16&255,u[d++]=h>>8&255,u[d++]=255&h;return 2===a?(h=e[t.charCodeAt(r)]<<2|e[t.charCodeAt(r+1)]>>4,u[d++]=255&h):1===a&&(h=e[t.charCodeAt(r)]<<10|e[t.charCodeAt(r+1)]<<4|e[t.charCodeAt(r+2)]>>2,u[d++]=h>>8&255,u[d++]=255&h),u},t.fromByteArray=function(t){let e;const n=t.length,o=n%3;let c="";const a=[];for(let r=0,e=n-o;r<e;r+=16383)a.push(h(t,r,r+16383>e?e:r+16383));return 1===o?(e=t[n-1],c+=r[e>>2],c+=r[e<<4&63],c+="=="):2===o&&(e=(t[n-2]<<8)+t[n-1],c+=r[e>>10],c+=r[e>>4&63],c+=r[e<<2&63],c+="="),a.push(c),a.join("")},t});
