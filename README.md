# FoN_SimpleFlightCom
***The Simplistic Flight Computer to make Orbital Mechanics simple.***

## Why do you need this?
When your crafts come with constant acceleration of 120m/s² from the ground to the orbit, and packed with massive dV of 40,000m/s, you don't really need to optimize your maneuvers. Just up in the air and go full throttle, you have plenty of gas to waste.

Sounds easy, right? If then why so many people fail to reach the station? Because this game practically has no UI to help you out. Yes, all it should do is nothing but tell you "This is the time, go full throttle" but it failed to do that.

My goal with this project is nothing seriously more complex than prompting **"GO FULL THROTTLE NOW"** in various occasions.

## What would this thing do?
The most basic features would be, obviously, Ascent-Rendezvous-Approach Guidance and Entry-Descent-Landing Guidance. Because of their nature, ARA Guidance needs much less effort and time, so it'll come out soon. EDL Guidance can't be simple down as much as ARA even with the brute force solution, if you don't want to make it as silly is "Kill all your orbital velocity at the middle of space, drop down straight forward to the landing site, decellerating with yoru engine" thing. It'll take a little bit of time.

### ARA Guidance
To make it as simple and straightforward as possible, it won't support efficient or customized ascent profile. It'll calculate everything based on the most simple trajectory, consisted of 3 stpes as below.

1. **Ascent:** Vertical takeoff to 500m altitude, pitch up to 60 degrees, go full throttle until your apoapsis reaches the target station's orbit.
2. **Rendezvous:** Wait the station catches you up at right distance. Go full throttle. Cut throttle once relative velocity gets close to 0m/s.
3. **Approach:** You'll be close to the target station with near-zero relative velocity, so you won't need any guidance to approach.

Based on this profile, the ARA-Guidance would calculate when you should take-off to minimize your flight time to the station, with safety margins. With the calculation, it will prompt you what number you should set on "Advanced mode: Station distance launch window" in game setting, and how long the trip would be.

### EDL Guidance
The best option to bleed off your orbital velocity is using aerdodynamic drag. However, aerodynamics is too complex to handle, way much harder than the orbital mechanics (of 2-body problem). There's no simple method to simulate a motion in the air other than run a numerical analysis.

So, my goal with EDL-Guidance would be safely bring you to the upper-atmosphere around the landing site, might be 35km altitude, with moderate descending angle and velocity. From there, you'll take control of your craft to approach and land at the base.

## What else?
At this point, this game dosn't make you to do any other serious orbital manevers other than ascending and descending, so I don't think we need more feature for this project. # FoN_SimpleFlightCom
***The Simplistic Flight Computer to make Orbital Mechanics simple.***

## Why do you need this?
When your crafts come with constant acceleration of 120m/s² from the ground to the orbit, and packed with massive dV of 40,000m/s, you don't really need to optimize your maneuvers. Just up in the air and go full throttle, you have plenty of gas to waste.

Sounds easy, right? If then why so many people fail to reach the station? Because this game practically has no UI to help you out. Yes, all it should do is nothing but tell you "This is the time, go full throttle" but it failed to do that.

My goal with this project is nothing seriously more complex than prompting **"GO FULL THROTTLE NOW"** in various occasions.

## What would this thing do?
The most basic features would be, obviosuly, Ascent-Rendezvous-Approach Guidance and Entry-Descent-Landing Guidance. Because of their nature, ARA Guidance needs much less effort and time, so it'll come out soon. EDL Guidance can't be simple down as much as ARA even with the brute force soultion, if you don't want to make it as silly is "Kill all your orbital velocity at the middle of space, drop down straight forward to the landing site, decellerating with yoru engine" thing. It'll take a little bit of time.

### ARA Guidance
To make it as simple and straightforward as possible, it won't support efficient or customized ascent profile. It'll calculate everything based on the most simple trajectory, consisted of 2 stpes as below.

1. **Ascent:** Vertical takeoff to 500m altitude, pitch up to 60 degrees, go full throttle until your apoapsis reaches the target station's orbit.
2. **Rendezvous:** Wait the station catches you up at right distance. Go full throttle. Cut throttle once relative velocity gets close to 0m/s.
3. **Approach:** You'll be close to the target station with near-zero relative velocity, so you won't need any guidance to approach.

Based on this profile, the ARA-Guidance would calculate when you should take-off to minimize your fligth time to the station, with safety margins. With the calculation, it will prompt you what number you should set on "Advanced mode: Station distance launch window" in game setting, and how long the trip would be.

### EDL Guidance
The best option to bleed off your orbital velocity is using aerdodynamic drag. However, aerodynamics is too complex to handle, way much harder than the orbital mechanics (of 2-body problem). There's no simple method to simulate a motion in the air other than run a numerical analysis.

So, my goal with EDL-Guidance would be safely bring you to the upper-atmosphere around the landing site, might be 35km altitude, with moderate descending angle and velocity. From there, you'll take control of your craft to approach and land at the base.

## What else?
At this point, this game dosn't make you to do any other serious orbital manevers other than ascending and descending, so I don't think we need more feature for this project. Ballistic Flight Planner might be handy for some intercontinental-class long haul missions, but let me see how this game grows.

