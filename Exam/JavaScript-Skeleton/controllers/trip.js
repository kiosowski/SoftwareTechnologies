const Trip = require('../models/Trip');

module.exports = {
    index: (req, res) => {
        Trip.find().then(trips => {
            return res.render('trip/index',{'trips' : trips});
        })
    },
    createGet: (req, res) => {
        res.render('trip/create');
    },
    createPost: (req, res) => {
        let trip = req.body;
        Trip.create(trip).then(trip => {
            res.redirect("/");
        })
    },
    editGet: (req, res) => {
        let tripId = req.params.id;
        Trip.findById(tripId).then(trip => {
            if(trip){
                res.render('trip/edit',trip);
            }
            else{
                res.redirect('/');
            }
        })
    },
    editPost: (req, res) => {
        let tripId = req.params.id;
        let trip = req.body;

        Trip.findByIdAndUpdate(tripId,trip,{runValidators: true}).then(trip=>{
            res.redirect("/");
            trip.id = tripId;
            return res.render("trip/edit",trip);
        })
    },
    deleteGet: (req, res) => {
        let id = req.params.id;
        Trip.findById(id).then(trip =>{
            if(trip){
                return res.render('trip/delete',trip);
            }
            else{
                return res.redirect('/');
            }
        })
    },
    deletePost: (req, res) => {
        let id = req.params.id;
        Trip.findByIdAndRemove(id).then(data => {
            res.redirect('/');
        })
    }
};