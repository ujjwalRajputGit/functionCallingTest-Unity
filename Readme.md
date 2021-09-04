### Object enable script disable
only awake called

### Object disable script enable
nothing

### Object disable script disable
nothing

### Object parent disable script disable
nothing

## conculsion
if the object is disable none of the method is called of its component.
but if the object is enable and the component is disable only the awake method is called.
if parent is disable then child is also consides as disable.

update method is also called only if both child and component is enable.

awake and the start method called only once in its life cycle (when scene restart life cycle restart).

Awake => OnEnable => Start => FixedUpdate => Update => LateUpdate => OnDisable => OnDestroy