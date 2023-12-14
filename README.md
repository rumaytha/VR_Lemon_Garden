# VR_Lemon_Garden
Project Description:
Our innovative project merges technology and mental health by harnessing the power of Virtual Reality (VR) to simulate a natural, stress-relieving environment. The project is centered around creating a virtual lemon garden in VR, a setting known for its soothing effects and ability to enhance emotional well-being.The user can customize his garden and grow the lemons he wants on the tree (or turn then off) to design the garden of his liking. This initiative is particularly relevant for urban dwellers with limited access to natural spaces, offering a digital sanctuary to unwind and connect with nature. Our VR application is backed by research indicating the positive impact of nature on stress reduction and mental health, making it an effective tool for modern, fast-paced lifestyles.

User Manual:

1. Starting the Experience:
    Put on your VR headset to start the program.
    There is no menu to navigate; a welcome banner provides instructions for ease of use.

2. Exploring the Virtual Garden:
    You will find yourself in a serene lemon garden with realistic terrain and a bright sky.
    Move around using VR controller:
    Navigate using the right controller’s thumbstick for forward, backward, and side-to-side movements.
    Rotate your view using the left controller’s thumbstick.

3. Interacting with the Environment and Lemons:
     Navigate using the right controller’s thumbstick for forward, backward, and side-to-side movements.
     Rotate your view using the left controller’s thumbstick.
     Approach lemon trees to find virtual water hoses.
     Use the hoses to water lemons, triggering their growth.
     You can also make lemons disappear to customize your garden by watering the grown lemon again.

4. Customization and Relaxation:
     Customize your garden by managing lemon growth.
     Enjoy the therapeutic effects of the virtual lemon garden.

5. Exiting the Program:
      To exit, simply remove your VR headset.

6. Safety Note:
     Ensure ample space around you to avoid accidents.
     Take breaks if you experience discomfort or dizziness.

Enjoy your journey through this tranquil virtual lemon garden, designed for relaxation and stress relief.

Problems Faced:

Problem 1: The lemon growth sequence initially experienced performance lag, impacting the smoothness of the game. We researched and found out that coroutines in Unity are effective for tasks that span several frames, which was ideal for this situation. To resolve this, we implemented a coroutine that begins when this line is reached StartCoroutine(GrowLemon()). This approach distributed the computational work of scaling the lemon's size across multiple frames, thereby reducing the immediate processing burden and smoothing out the growth animation, leading to a more fluid and less resource-intensive operation.


Problem 2: The instability in player movement and speed fluctuations posed a significant challenge. The solution involved two critical adjustments: normalizing the movementDirection vector and integrating Time.fixedDeltaTime in the movement calculations. Normalization ensured that movement remained consistent in direction, irrespective of the distance, while Time.fixedDeltaTime balanced the movement speed across different frame rates. This dual approach not only stabilized the movement but also enhanced the overall smoothness, crucial for a seamless VR experience.

Problem 3: The initial rapid and unrealistic growth of lemons was a jarring aspect of our VR environment. To address this, the elapsedTime variable was incorporated into the GrowLemon coroutine. This allowed for a controlled, time-based growth of the lemons, ensuring that their increase in size was gradual and more lifelike. The methodical increase over the set growth time transformed the lemon growth from a sudden change to a more gradual and smoother process.

Problem 4: The lack of suitable grass assets in the Unity Asset Store and having the ground look so flat really diminished the immersiveness and engaging visuals of the project. Therefore, we decided to create our own custom terrain. This task was not straightforward and involved several steps, from designing the terrain layout to selecting and applying a unique grass texture that fit the visual style of the game. This effort resulted in a distinct and visually pleasing environment, significantly enhancing the game's visual appeal and setting it apart from standard asset-based designs.

Problem 5: Managing a large VR project file presented significant logistical challenges, particularly in terms of file sharing and download times. These issues often led to bugs and inefficiencies in the development process. To address this, the team decided to centralize the development workflow on one teammate's laptop. This approach significantly reduced the complications associated with large file transfers and version control, streamlining the development process, and enhancing team collaboration and productivity.

What we would have done differently:
Diversifying Our Garden Design: We chose a lemon garden for its soothing effects, but it might have been interesting to include a variety of plants or even different garden themes. This could have provided a broader experience for users and a fun challenge for us to design.

Incorporating User Feedback Early On: We were pretty happy with our design and idea, but looking back, gathering early feedback from classmates could have given us valuable insights and possibly new ideas to enhance the user experience.

Playing with Visuals: Our garden had a consistent sunny atmosphere, and only bird background noise. Adjusting lighting to reflect different times of day (ike dawn or dusk)  might have made the environment more dynamic and engaging. Additionally adjusting different seasons in the environment and adding sounds that match it (like rain) might have created a more engaging environment for the user.

Scheduling Regular Team Check-ins: While we communicated and collaborated effectively, setting more structured work timelines for our work meetings could have ensured that the process be more smoothe.

Note: Overall we are happy with our project given that it is our first VR experience and we hope the users of this program enjoy it as well.
