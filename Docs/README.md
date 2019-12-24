# observer-pattern
A generic take on the observer pattern.

# Overview
In this example, the ScoreManager is the subject and the Canvas is the observer. At the start of the game, the Canvas registers itself as an observer to the ScoreManager using the RegisterObserver() method from the ISubject interface inherited by the ScoreManager. While in play, the up and down arrows increment the score by 10 using the ScoreManager's method UpdateScore(). At the end of that UpdateScore() method, the NotifyObservers() method is called from the inherited ISubject interface, which contains the UpdateObserver() method from the inherited IObserver interface.