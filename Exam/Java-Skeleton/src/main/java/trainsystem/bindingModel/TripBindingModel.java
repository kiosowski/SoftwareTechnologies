package trainsystem.bindingModel;

public class TripBindingModel {
    private Integer id;

    private String origin;

    private String destination;

    private Integer business;

    private Integer economy;


    public TripBindingModel() {

    }

    public TripBindingModel(Integer id, String origin, String destination, Integer business, Integer economy) {
        this.id = id;
        this.origin = origin;
        this.destination = destination;
        this.business = business;
        this.economy = economy;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getOrigin() {
        return origin;
    }

    public void setOrigin(String origin) {
        this.origin = origin;
    }

    public String getDestination() {
        return destination;
    }

    public void setDestination(String destination) {
        this.destination = destination;
    }

    public Integer getBusiness() {
        return business;
    }

    public void setBusiness(Integer business) {
        this.business = business;
    }

    public Integer getEconomy() {
        return economy;
    }

    public void setEconomy(Integer economy) {
        this.economy = economy;
    }
}

