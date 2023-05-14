function Konum() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var latitude = position.coords.latitude;
            var longitude = position.coords.longitude;

            var url = "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + latitude + "," + longitude + "&key=AIzaSyA8QHce1U_MXY5J4DjdEz_ITzt-zooUdqc";

            fetch(url)
                .then(response => response.json())
                .then(data => {
                    if (data.status == "OK") {
                        /*console.log("Adres: " + data.results[0].formatted_address);*/

                        alert("Adres: " + data.results[0].formatted_address+"\nKoordinatlar: " + latitude + " - " + longitude);
                    } else {
                        alert("Adres bulunamadı");
                    }
                });
        });
    } else {
        alert("Konum verileri kullanılamıyor.");
    }
}