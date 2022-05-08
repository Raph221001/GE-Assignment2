# GE-Assignment2

Name: Raphael Ofeimu

Student Number: C18359123

Class Group: DT 282/4

# Description of Project

This project is about a ship that is being chased through space by droids and other ships that are preventing the ship from reaching home. The ship must navigate its way past the enemies and avoid other objects like asteroids to reach its destination. 

![pic1](https://user-images.githubusercontent.com/55786050/167305212-32815e42-6783-4e1c-b62a-e638a4092a0d.png)


![pic2](https://user-images.githubusercontent.com/55786050/167305213-0dc5a4c5-73ab-4f4a-be62-788c345bc4e6.png)


![pic3](https://user-images.githubusercontent.com/55786050/167305214-61d086c0-55cb-47ca-b546-57b22ea493e9.png)


![pic4](https://user-images.githubusercontent.com/55786050/167305217-0ab7103d-7cfb-45cd-b60a-7e13b5b0088d.png)

# Behaviours

The behaviours used in this project include Path, Wander, ObstacleAvoidance and much more. There were also other behaviours that were edited and some scripts that were created myself such as Asteroid_Field.

# Assets used

- Droid

- Luminaris Starship

- BreakableAsteroids

- SF_Fighter

# Important code

```C#
void Update()
    {
        Timer += Time.deltaTime;

        if (Timer < 2)
        {
            transform.position = Vector3.Slerp(transform.position, BaseTarget.position+pos, Time.deltaTime); 
            transform.LookAt(BaseTarget); 
        }
        
        if (Timer > 2 && Timer < 10)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget1.position+pos, Time.deltaTime);
            transform.LookAt(CameraTarget1); 
        }

        if (Timer > 10 && Timer < 20)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget2.position+pos, Time.deltaTime);
            
            transform.LookAt(CameraTarget2); 
        }
        
        if (Timer > 20 && Timer < 25)
       {
            transform.position = Vector3.Slerp(transform.position, CameraTarget3.position+pos, Time.deltaTime);
            transform.LookAt(CameraTarget3); 
        }
        
        if (Timer > 25 && Timer < 35)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget4.position+pos, Time.deltaTime);
            transform.LookAt(CameraTarget4); 
        }

        if (Timer > 35 && Timer < 60)
        {
            transform.position = Vector3.Slerp(transform.position, CameraTarget1.position+pos, Time.deltaTime);
            transform.LookAt(CameraTarget1); 
        }
        
    }
```
The CameraMover script focuses on the different targets that are set depending on the timer. At different times different targets will be focused on to ensure that all of the objects in the scene can be viewed at some point.

```C#
private void Start()
    {
        randomAsteroid = new int[numOfAsteroids];
        speedRange = new float[numOfAsteroids];
        asteroidClones = new GameObject[numOfAsteroids];


        Random.InitState(seed);

        for (int i = 0; i < numOfAsteroids; i++)
        {
            randomAsteroid[i] = Random.Range(0, 6);
            speedRange[i] = Random.Range(10, 15);

            asteroidClones[i] = Instantiate(asteroids[randomAsteroid[i]], new Vector3(transform.position.x + Random.Range(-spawnRange.x, spawnRange.x),
                                                                                      transform.position.y + Random.Range(-spawnRange.y, spawnRange.y),
                                                                                      transform.position.z + Random.Range(-spawnRange.z, spawnRange.z)), Quaternion.identity);

            asteroidClones[i].transform.GetComponent<Rigidbody>().velocity = transform.forward * speedRange[i];
            asteroidClones[i].transform.parent = this.transform;
        }
    }
```
In the Asteroid_field script the asteroids are created and spawned in random positions.
