URL_ENDPOINT = "http://localhost:32691/api/OPD";

function getPatient(id, callback){
    fetch(`${URL_ENDPOINT}/${id}`)
        .then(dat=>dat.json())
        .then(obj=>callback(obj))
}

document.getElementById("submit").addEventListener("click", searchPatient);
console.log(document.getElementById("submit"))
console.log("bound")

function searchPatient(e){
    e.preventDefault();
    let id = document.getElementById("patient-id").value;
    console.log("Triggered")
    getPatient(id, obj=>{
        console.log(obj.PatientID)
        console.log(JSON.stringify(obj));
    });
}