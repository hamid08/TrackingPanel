function init() {
    var map = L.map('map', {
        center: [52.0, -11.0],
        zoom: 5,
        layers: [
            L.tileLayer('http://map.separta.ir/tile/{z}/{x}/{y}.png', {
                attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
            })
        ]
    });

    // --- Example with an array of Polylines ---

    var multiCoords1 = [
       
        [
            ////1
            //[35.585718, 51.364908],
            //[35.584601, 51.363996],
            //[35.585255, 51.362183],
            //[35.586084, 51.362773],
            //[35.585735, 51.364082],

            ////2
          
            [35.585542666666669, 51.363747666666676],
            [35.585468, 51.363846],
            [35.5855965, 51.3635595],
            [35.585614, 51.363508]

        ]
    ];
    var plArray = [];
    for (var i = 0; i < multiCoords1.length; i++) {
        plArray.push(L.polyline(multiCoords1[i], { color: 'green', weight: 3, opacity: 1, smoothFactor: 1 }).addTo(map));
    }


    var polyline = L.polylineDecorator(multiCoords1, {
        patterns: [
            { offset: 25, repeat: 50, symbol: L.Symbol.arrowHead({ pixelSize: 15, pathOptions: { fillOpacity: 1, weight: 0, color: 'red' } }) }
        ]
    }).addTo(map);

    map.fitBounds(polyline.getBounds());

    //L.circle([35.585542666666669, 51.363747666666676], {color: 'red',fillColor: '#f03',fillOpacity: 0.5, radius: 5}).addTo(map);
    //L.circle([35.585468, 51.363846], {color: 'red',fillColor: '#f03',fillOpacity: 0.5, radius: 5}).addTo(map);
    //L.circle([35.5855965, 51.3635595], {color: 'red',fillColor: '#f03',fillOpacity: 0.5, radius: 5}).addTo(map);
    //L.circle([35.585614, 51.363508], {color: 'red',fillColor: '#f03',fillOpacity: 0.5, radius: 5}).addTo(map);



}