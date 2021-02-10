//Encabezado necesario para hacer la petición en DNN (GET,POST,DELETE,PUT)
var $self = this;
if ($.ServicesFramework) {
    var _sf = $.ServicesFramework(contentLibraryMigrateId);
    $self.ServiceRoot = _sf.getServiceRoot('Julius.ContentLibrary.Migrate');
    $self.ServicePath = $self.ServiceRoot + "item/";
    $self.Headers = {
        "ModuleId": _sf.getModuleId(),
        "TabId": _sf.getTabId(),
        "RequestVerificationToken": _sf.getAntiForgeryValue()
    };
}

get = async function () {
    fetch(`${$self.ServicePath}Get?apiKey=${document.querySelector('input[name=key-source]').value}`, {
        method: "GET",
        headers: $self.Headers
    }).then(function (e) {
        return e.json();
    }).then(function (a) {
        if (a.ContentType) {

            var category = [];

            a.ContentType.documents.forEach(function (e, i) {

                let exist = category.filter(function (o) {
                    return o == e.contentTypeName;
                })

                if (exist.length == 0) {
                    let option = document.createElement('option');
                    option.value = e.contentTypeId;
                    option.text = e.contentTypeName;
                    document.querySelector('select[name=combo-filter-content-type]').append(option);
                    category.push(e.contentTypeName);
                }

                let div = document.createElement(`div`);
                let check = document.createElement('input');
                check.type = 'checkbox';
                check.id = e.id;
                let label = document.createElement('label');
                label.innerHTML = `${e.name}`;
                label.setAttribute('for', e.id);
                div.append(check);
                div.append(label);
                div.className = e.contentTypeId
                document.querySelector('#wrap-content-type').append(div);
            });

            document.querySelector('select[name=combo-filter-content-type]').addEventListener("change", (event) => {
               

                document.querySelectorAll('#wrap-content-type div').forEach(function (e, i) {
                    e.setAttribute('style', 'display:none');
                })

                document.querySelectorAll(`#wrap-content-type div.${event.currentTarget.value}`).forEach(function (e, i) {
                    e.setAttribute('style', 'display:block');
                })
            });
        }
    });
}