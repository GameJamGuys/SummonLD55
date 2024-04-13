﻿using System;
using System.Collections.Generic;
using Code.Core.Ingredients;
using DefaultNamespace;
using UnityEngine;

namespace Code
{
    public class RecipesManager : MonoBehaviour
    {
        [SerializeField] private List<Recipe> recipes = new List<Recipe>();
        [SerializeField] private List<IngredientSOType> ingredients = new List<IngredientSOType>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                bool success = recipes[0].CheckIngredients(ingredients);
                if (success)
                    Debug.Log("SUCCESS");
                else
                {
                    Debug.Log("FAIL");
                }
            }
        }
    }
}