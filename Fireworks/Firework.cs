using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fireworks {

    class Firework {
        // Gravitional acceleration, in m/s^2.
        private static readonly float GRAVITY = -9.81f;

        // Random numbers generator for the fireworks.
        private static readonly Random RND_GEN = new Random();

        // Returns a random float in the given range, both values inclusive,
        // with granularity of 0.001.
        private static float GetRandomInRange(float min, float max) {
            return 0.001f * (float)RND_GEN.Next((int)(min * 1000.0f),
                                                (int)(max * 1000.0f) + 1);
        }

        // Time for the firework to explode, relative to CurrentLifeTime, in seconds.
        private readonly float FuseTime;

        // Constraints on randomness of fragment velocities, in m/s.
        // All values inclusive.
        private readonly float MinFragmentVx;
        private readonly float MaxFragmentVx;
        private readonly float MinFragmentVy;
        private readonly float MaxFragmentVy;

        // Constraints on brightness of fragments.
        // All values inclusive.
        private readonly float MinBrightness;
        private readonly float MaxBrightness;

        // Constraints on the count of fragments at the moment of explosion.
        // All values inclusive.
        private readonly int MinFragments;
        private readonly int MaxFragments;

        // Rate of fragment burn-out, in relative units per second (0...1).
        private readonly float BurnRate;

        // Multipliers to generate the color of the firework.
        private readonly float ColorR;
        private readonly float ColorG;
        private readonly float ColorB;

        // Time passed since the firework was created, in seconds.
        private float CurrentLifeTime = 0.0f;

        // Coordinates {x, y} of fragments of the firework, in meters.
        private readonly List<Tuple<float, float>> FragmentPositions =
            new List<Tuple<float, float>>();

        // Velocities {vx, vy} of fragments of the firework, in m/s.
        private readonly List<Tuple<float, float>> FragmentVelocities =
            new List<Tuple<float, float>>();

        // Brightness of fragments, in relative units [0...1].
        private readonly List<float> FragmentBrightnesses = new List<float>();

        // Constructs a firework in its initial time, fired at a given
        // location, with given constraints on randomness of events in the
        // firework's life time.
        public Firework(float initialX, float initialY,
                        float minFuseTime, float maxFuseTime,
                        float minVx, float maxVx,
                        float minVy, float maxVy,
                        float minFragmentVx, float maxFragmentVx,
                        float minFragmentVy, float maxFragmentVy,
                        float minBrightness, float maxBrightness,
                        int minFragments, int maxFragments,
                        float minBurnRate, float maxBurnRate) {
            MinFragmentVx = minFragmentVx;
            MaxFragmentVx = maxFragmentVx;
            MinFragmentVy = minFragmentVy;
            MaxFragmentVy = maxFragmentVy;
            MinBrightness = minBrightness;
            MaxBrightness = maxBrightness;
            MinFragments = minFragments;
            MaxFragments = maxFragments;
            BurnRate = GetRandomInRange(minBurnRate, maxBurnRate);

            ColorR = GetRandomInRange(0.25f, 1.0f);
            ColorG = GetRandomInRange(0.25f, 1.0f);
            ColorB = GetRandomInRange(0.25f, 1.0f);

            FragmentPositions.Add(new Tuple<float, float>(initialX, initialY));
            FragmentVelocities.Add(new Tuple<float, float>(
                GetRandomInRange(minVx, maxVx),
                GetRandomInRange(minVy, maxVy)));
            FuseTime = GetRandomInRange(minFuseTime, maxFuseTime);
        }

        // Paints the firework in its current state in the given graphics
        // context, having the zero point at the given coordinates in that
        // graphics context. One pixel is one meter. All traces are drawn as
        // lines beginning back in time by the given amount of seconds.
        public void Paint(Graphics graphics,
                          float zeroX, float zeroY,
                          float backTraceTime) {

            if (FragmentBrightnesses.Count == 0) {
                // The firework has not yet exploded, draw the rocket.

                Tuple<float, float> currentPosition = FragmentPositions[0];
                Tuple<float, float> currentVelocity = FragmentVelocities[0];

                graphics.DrawLine(
                    Pens.DimGray,
                    zeroX + currentPosition.Item1 - backTraceTime * currentVelocity.Item1,
                    zeroY - (currentPosition.Item2 - backTraceTime * currentVelocity.Item2),
                    zeroX + currentPosition.Item1,
                    zeroY - currentPosition.Item2);
            } else {
                // The firework has exploded, draw all fragments in their
                // current brighntess.

                List<Tuple<float, float>>.Enumerator positionEnum =
                    FragmentPositions.GetEnumerator();
                List<Tuple<float, float>>.Enumerator velocityEnum =
                    FragmentVelocities.GetEnumerator();

                foreach (float brightness in FragmentBrightnesses) {
                    positionEnum.MoveNext();
                    velocityEnum.MoveNext();

                    Tuple<float, float> currentPosition = positionEnum.Current;
                    Tuple<float, float> currentVelocity = velocityEnum.Current;
                    float currentBrightness = 255.0f * brightness;

                    graphics.DrawLine(
                        new Pen(Color.FromArgb((int)(ColorR * currentBrightness),
                                               (int)(ColorG * currentBrightness),
                                               (int)(ColorB * currentBrightness))),
                        zeroX + currentPosition.Item1 - backTraceTime * currentVelocity.Item1,
                        zeroY - (currentPosition.Item2 - backTraceTime * currentVelocity.Item2),
                        zeroX + currentPosition.Item1,
                        zeroY - currentPosition.Item2);
                }

            }

        }

        // Forwards the firework in its life cycle by the given time step (in
        // seconds). Returns 'true' if the firework is still burning, 'false'
        // if all fragments are burnt-out.
        public bool Forward(float timeStep) {
            CurrentLifeTime += timeStep;

            if (FragmentBrightnesses.Count == 0) {
                // The forework has not yet exploded - check if it should, and
                // either advance the single rocket, or "explode" and let the
                // code handling fragments kick in.

                if (CurrentLifeTime < FuseTime) {
                    Tuple<float, float> currentPosition = FragmentPositions[0];
                    Tuple<float, float> currentVelocity = FragmentVelocities[0];
                    FragmentPositions[0] = new Tuple<float, float>(
                        currentPosition.Item1 + timeStep * currentVelocity.Item1,
                        currentPosition.Item2 + timeStep * currentVelocity.Item2);
                    FragmentVelocities[0] = new Tuple<float, float>(
                        currentVelocity.Item1,
                        currentVelocity.Item2 + timeStep * GRAVITY);
                    return true;
                }

                // "Booom!" :-)

                int fragmentCount = RND_GEN.Next(MinFragments, MaxFragments + 1);
                Tuple<float, float> boomPos = FragmentPositions[0];
                Tuple<float, float> boomVel = FragmentVelocities[0];
                FragmentPositions.Clear();
                FragmentVelocities.Clear();

                for (int k = 0; k < fragmentCount; k++) {
                    FragmentPositions.Add(boomPos);
                    FragmentVelocities.Add(new Tuple<float, float>(
                        boomVel.Item1 + GetRandomInRange(MinFragmentVx, MaxFragmentVx),
                        boomVel.Item2 + GetRandomInRange(MinFragmentVy, MaxFragmentVy)));
                    FragmentBrightnesses.Add(GetRandomInRange(MinBrightness, MaxBrightness));
                }

            }

            // Let's animate the fragments.

            bool result = false;

            for (int k = 0, kLimit = FragmentPositions.Count; k < kLimit; k++) {
                Tuple<float, float> pos = FragmentPositions[k];
                Tuple<float, float> vel = FragmentVelocities[k];
                FragmentPositions[k] = new Tuple<float, float>(
                    pos.Item1 + timeStep * vel.Item1,
                    pos.Item2 + timeStep * vel.Item2);
                FragmentVelocities[k] = new Tuple<float, float>(
                    vel.Item1, vel.Item2 + timeStep * GRAVITY);

                FragmentBrightnesses[k] -= timeStep * BurnRate;

                if (FragmentBrightnesses[k] < 0.0f) {
                    FragmentBrightnesses[k] = 0.0f;
                } else {
                    result = true;
                }

            }

            return result;
        }

    }

}
