﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HealthNode : Node {
    private EnemyAI ai;
    private float threshold;

    public HealthNode(float threshold, EnemyAI ai) {
        this.ai = ai;
        this.threshold = threshold;
    }

    public override NodeState Evaluate() {
        return ai.CurrentHealth <= threshold ? NodeState.SUCCESS : NodeState.FAILURE;
    }
}