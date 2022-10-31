# Idea

🪐🚀☄️🛰️🧑‍🚀✨🌍🌑☀️⭐🌟🌠

This is a space trading game.  The idea is to make as much money as possible, within the time limit.
You can make money by exploiting the price difference for various resources on various planets.

## Game Objects

### Time

You have 50 days to make as money as possible.

### Player

You!  A space trader with a cargo ship.

Properties:

- Balance
- Health
- Ship

### Ship

Use your ship to move resources from one planet to another.  You can upgrade or replace your ship, 
for a price.

Properties:

- Shields
- Firepower
- Speed
- Max range
- Cargo hold size

### Planet

There are a number of planets within the game.

If a planet has lots of some resource it will push down the price.  While rarer resources are much
more expensive.  Rare and common resources differ between planets.  A trader cargo ship could make
some money here.

Properties:

- Resources
- Safety rating
- Taxes

### Web

Keep up to date with the latest news.  You may spot hints and tips here.

Properties:

- Resources
- Fiscal impact (positive or negative)

### Price List

View the price for various resources on all the different planets.

Properties:

- Resource
- Price (positive or negative)

## Game

Travel between worlds takes days.  The speed of your ship will determine how long it takes.  While
the maximum range dictates where you can go next.

Once you arrive you can sell whatever is currently in your cargo hold.  

As long as there is space in your ship you can buy resources, to sell later on.

## Main Loop

```psuedocode
while (true)
  increment-clock()
```
