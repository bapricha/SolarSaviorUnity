extends CharacterBody2D

@export var SPEED = 950
@export var jump_impulse = -500
@export var FALL_ACCELERATION = 50
@export floor

var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")
var target_velocity = Vector2.ZERO

func _physics_process(delta):
	var direction = Vector2.ZERO
	
	if(Input.is_action_pressed("right")):
		direction.x += 1
	if(Input.is_action_pressed("left")):
		direction.x += -1
	
	#if direction != Vector2.ZERO:
#		direction = direction.normalized()
	
	target_velocity.x = direction.x * SPEED

	if not is_on_floor() and target_velocity.y > 0:
		target_velocity.y = target_velocity.y - (FALL_ACCELERATION * delta)
	if is_on_floor() and Input.is_action_just_pressed("up"):
		target_velocity.y = jump_impulse
	
	velocity = target_velocity
	move_and_slide()



