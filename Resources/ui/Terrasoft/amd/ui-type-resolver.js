(function() {

    function getCookie() {
        return document.cookie
            .split(';')
            .map(v => v.split('='))
            .reduce((acc, v) => {
                acc[decodeURIComponent(v[0].trim())] = decodeURIComponent(v[1].trim());
                return acc;
            }, {});
    }

    function addPathEndSlash(path) {
        if (!path.endsWith('/')) {
            path += '/';
        }
        return path;
    }

    function getWorkspaceBaseUrl() {
        let pathName = location.pathname;
        const matches = pathName.match(/.*?\/\d\/?/);
        if (matches && matches.length === 1) {
            pathName = addPathEndSlash(matches[0]);
        } else {
            pathName = '';
        }
        return joinPath(location.origin, pathName);
    }

    function joinPath(...pathParts) {
        return pathParts.map((path) => trimSlashes(path)).join('/');
    }

    function trimSlashes(path) {
        return path.replace(/(^([/\\])+)|(([/\\])+$)/, '');
    }

    function loadClassicUI() {
        const baseUrl = getWorkspaceBaseUrl().slice(0, -1);
        const el = document.createElement('script');
        const prefix = document.cookie.match(new RegExp('(^| )' + 'UserType' + '=([^;]+)'))?.[2] === 'SSP' ? 'ssp/' : '';
        el.setAttribute('type', 'text/javascript');
        el.setAttribute('data-loadbootstrap', 'bootstrap.configuration');
        el.setAttribute('data-clientscriptendpointprefix', `${prefix}api/ClientScript`);
        el.setAttribute('data-clientscriptendpoint', 'GenerateViewModuleScripts');
        el.setAttribute('data-baseurl', baseUrl);
        el.setAttribute('src', baseUrl + '/core/hash/Terrasoft/amd/bootstrap-loader.js');
        document.head.appendChild(el);
    }
    
    function hasClassicUIParameter() {
        const search = window.location.search;
        return search.toLowerCase().includes('classicui');
    }
    
    function canUseFreedomUI() {
        return new Promise((resolve, reject) => {
            const cookie = getCookie();
            const xhr = new XMLHttpRequest();
            const baseUrl = getWorkspaceBaseUrl();
            const url = baseUrl+ 'ServiceModel/ApplicationInfoService.svc/CanUseFreedomUI';
            xhr.open('POST', url, true);
            xhr.setRequestHeader('Content-type', 'application/json');
            xhr.setRequestHeader("Accept","application/json");
            const cookieName = 'BPMCSRF';
            xhr.setRequestHeader(cookieName,cookie[cookieName]);
            xhr.onreadystatechange = () => {
                if (xhr.readyState === XMLHttpRequest.DONE) {
                    const status = xhr.status;
                    if (status === 0 || (status >= 200 && status < 400)) {
                        resolve(xhr.responseText === "true");
                    } else {
                        reject(new Error(xhr.statusText));
                    }
                }
            };
            xhr.send(JSON.stringify(location.href));
        })
    }

    function loadFreedomUI() {
        const href = window.location.href;
        const shellHref = href.replace(/nui\/viewmodule.(aspx|html)/i, 'Shell/');
        window.location.replace(shellHref);
    }

    async function resolveUIType() {
        if (!hasClassicUIParameter() && await canUseFreedomUI()) {
            loadFreedomUI();
        } else {
            loadClassicUI();
        }
    }

    resolveUIType();
})();
