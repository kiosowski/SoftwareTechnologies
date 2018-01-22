package trainsystem.entity;

import javax.persistence.*;

@Entity
@Table(name = "trips")
public class Trip {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    @Column(nullable = false)
    private String origin;
    @Column(nullable = false)
    private String destination;
    @Column(nullable = false)
    private Integer business;
    @Column(nullable = false)
    private Integer economy;

    public Integer getId(){
        return this.id;
    }

    public void setId(Integer id){
        this.id = id;
    }

    public String getOrigin(){
        return origin;
    }

    public void setOrigin(String origin){
        this.origin = origin;
    }

    public String getDestination(){
        return destination;
    }

    public void setDestination(String destination){
        this.destination = destination;
    }

    public Integer getBusiness(){
        return business;
    }

    public void setBusiness(Integer business){
        this.business = business;
    }

    public Integer getEconomy(){
        return economy;
    }

    public void setEconomy(Integer economy){
        this.economy = economy;
    }




}