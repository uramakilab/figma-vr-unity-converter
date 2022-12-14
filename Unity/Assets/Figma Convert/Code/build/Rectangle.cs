using UnityEngine;

public class Rectangle : Object {

    public Rectangle(ObjectProperty obj, string apiImage, float eixoZ, int escala) : base(obj, apiImage, eixoZ, escala){}
    
    public GameObject createObject(){
        cornerRadius();
        setSize();
        setPosition();
        setColor();
        return gameObject;
    }

    public void cornerRadius() {
        if(obj.cornerRadius == 0){
            gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            return;
        }
        Create create = new Create(obj.cornerRadius/40, obj.strokeWeight-1, obj.absoluteBoundingBox.height, obj.absoluteBoundingBox.width);
        create.createCubo();
    }
}