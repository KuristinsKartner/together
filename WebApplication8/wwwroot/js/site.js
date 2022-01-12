// часть 1
let inputs = document.querySelectorAll('.input__file');
Array.prototype.forEach.call(inputs, function (input) {
    let label = input.nextElementSibling;
    console.log('ok1')
    document.getElementsByTagName('input')[0].onchange = function () {
        if (this.files[0]) // если выбрали файл
            label.querySelector('.input__file-button-text').innerText = this.files[0].name;
    };

});

//часть 2

let dropArea = document.getElementById("drop-area")

    // сброс обработчика по уполчанию
    ;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
        document.body.addEventListener(eventName, preventDefaults, false)
    })

function preventDefaults(e) {
    e.preventDefault()
    e.stopPropagation()
}

// индикатор перетаскивания
;['dragenter', 'dragover'].forEach(eventName => {
    dropArea.addEventListener(eventName, highlight, false)
})

    ;['dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, unhighlight, false)
    })

function highlight(e) {
    dropArea.classList.add('highlight')
}

function unhighlight(e) {
    dropArea.classList.remove('highlight')
}

// перетаскивание файла
dropArea.addEventListener('drop', handleDrop, false)

function handleDrop(e) {
    var dt = e.dataTransfer
    var files = dt.files

    handleFiles(files)
}
//к каждому files испольщуем uploadFile
function handleFiles(files) {
    ([...files]).forEach(uploadFile)
}

function uploadFile(file) {
    console.log("ok")
    //let url = 'file://localhost/E:/fun here/fun/dnd/upload'
    /*
      let formData = new FormData()
    
      formData.append('file', file)
        fetch(url, {
          method: 'POST',
          body: formData
        })
        .then(() => { alert('ok') })
        .catch(() => { alert('smth wrong') })
    */


    // хочу изменить имя у label
    document.getElementById('in__text').innerText = file.name;

};


