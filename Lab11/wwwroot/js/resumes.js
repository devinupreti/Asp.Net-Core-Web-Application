// initialize resume list on load
window.onload = function () {
    refresh();
}

function refresh() {
    const request = new XMLHttpRequest();
    const url = 'http://localhost:57584/api/Files';
    request.open("GET", url);
    request.send();
    request.onreadystatechange = function () {
        // Begin accessing JSON data here
        if (this.readyState == 4 && this.status == 200)
        {
            var resumeHolder = document.getElementById("resumeHolder");
            while (resumeHolder.firstChild) {
                resumeHolder.removeChild(resumeHolder.firstChild);
            }
            var result = request.response;
            var files = result.split(",");
            
            var table = document.createElement('table');
            if (files.length > 1) {
                var tHead = document.createElement('thead');
                var trHead = document.createElement('tr');

                var fileName = document.createElement('th');
                var textH1 = document.createTextNode("File Name");
                fileName.appendChild(textH1);

                var downloadFile = document.createElement('th');
                var textH2 = document.createTextNode("Download File");
                downloadFile.appendChild(textH2);

                var deleteFile = document.createElement('th');
                var textH3 = document.createTextNode("Delete File");
                deleteFile.appendChild(textH3);

                trHead.append(fileName);
                trHead.append(downloadFile);
                trHead.append(deleteFile);
                tHead.append(trHead);
                table.appendChild(tHead);
            }
            for (var i = 0; i < files.length - 1; i++) {
                var tr = document.createElement('tr');

                var td1 = document.createElement('td');
                var text1 = document.createTextNode(files[i]);
                td1.appendChild(text1);

                var td2 = document.createElement('td');
                var link2 = document.createElement('a');
                var durl = "http://localhost:57584/api/Files/" + i;
                link2.setAttribute("href", durl);
                link2.setAttribute("target", "_blank");
                link2.text = "Download "+ files[i];
                td2.appendChild(link2);

                // Delete
                var td3 = document.createElement('td');
                var link3 = document.createElement('a');
                var delUrl = 'http://localhost:57584/api/Files/delete/' + i;
                link3.setAttribute("href", delUrl);
                link3.setAttribute("target", "_blank");
                link3.text = "Delete";
                td3.appendChild(link3);
                
                tr.appendChild(td1);
                tr.appendChild(td2);
                tr.appendChild(td3); // delete

                table.appendChild(tr);
            }
            resumeHolder.appendChild(table);
            var lineBreak = document.createElement('br');
            resumeHolder.appendChild(lineBreak);
        }
        else {
            console.log('error')
        }
    }
}
