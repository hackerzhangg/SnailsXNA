﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using TwoBrainsGames.BrainEngine;
using Microsoft.Xna.Framework;
using TwoBrainsGames.BrainEngine.UI.Screens;
using TwoBrainsGames.BrainEngine.UI.Screens.Effects;

namespace TwoBrainsGames.BrainEngine.UI.Screens.Transitions
{
    public class BlurTransition : Transition
	{

        private const int TRANSITION_TIME = 200;

        Texture2D _texture = null;
        GaussianBlur _blurEffect;
        float _time;
		public bool Ended;
        bool _isGray;
        private UIScreen _screen;
        private float _alpha;
        private bool _fadingOut;
        private Rectangle _drawRect;
        private int _iterations; // Blur strenght - number of times the blur will be performed
        private int _strenghCounter; // The blur is performed "strength" times. This controls that
        private double _iterationTime; // in msecs

        #region Properties
        // Store the render target. This is used to check if the texture content was lost
        protected RenderTarget2D RenderTarget
        {
            get { return this._texture as RenderTarget2D; }
        }

        public Texture2D TextureToBlur 
        {
            get { return _texture; }
            set 
            { 
                _texture = value;
                _blurEffect.Texture = _texture;
            }
        }
        public Color BackgroundColor { get; set; }
        public bool IsTransitionOut { get; private set; } // true if the OnTransitonEnded is called when the blur is removed
        protected UIScreen ScreenOwner { get { return this._screen; } }

        #endregion

        public BlurTransition(UIScreen screen)
            : this(screen, false, 1, 10)
        { }

        public BlurTransition(UIScreen screen, bool isGray, int iterations, double iterationTime)
		{
            this._screen = screen;
            this._isGray = isGray;
            this._drawRect = new Rectangle(0, 0, BrainGame.ScreenWidth, BrainGame.ScreenHeight);
            this._iterations = iterations;
            this._blurEffect = (this._isGray) ? new GaussianBlurGray(this._screen) : new GaussianBlur(this._screen);
            this._iterationTime = iterationTime;
            this.Reset();

        }

        /// <summary>
        /// 
        /// </summary>
		public override void LoadContent()
		{
            base.LoadContent();
            _blurEffect.LoadContent();
		}
        
        /// <summary>
        /// Resets the blur to it's initial state
        /// </summary>
        public override void Reset()
        {
            base.Reset();
            this._blurEffect.LoadContent();
            this._alpha = 1.0f;
            this.Ended = false;
            this._time = 0;
            this._fadingOut = false;
            this._strenghCounter = 0;
        }

        /// <summary>
        /// 
        /// </summary>
		public override void Update(BrainGameTime gameTime)
		{
            base.Update(gameTime);
            if (this.Ended)
            {
            
                if (this._fadingOut)
                {
                    this._alpha -= 0.01f * (float)gameTime.ElapsedRealTime.TotalMilliseconds;
                    if (this._alpha < 0.0f)
                    {
                        this._fadingOut = false;
                        this.IsTransitionOut = true;
                        this.InvokeTransitonEnded();
                    }
                }
                return;
            }
        

            this._time += (float)gameTime.ElapsedRealTime.TotalMilliseconds;
            if (this._time > this._iterationTime)
            {
                this._strenghCounter++;
                this._time = 0;
                if (this._strenghCounter > this._iterations)
                {
                    this.Ended = true;
                    this.IsTransitionOut = false;
                    this.InvokeTransitonEnded();
                }
                else
                {
                    if (_texture != null)
                    {
                        _texture = this._blurEffect.Draw(_texture);
                    }
                }
            }
		}

        /// <summary>
        /// 
        /// </summary>
        public override void Draw()
        {
            base.Draw();
            // Well, something strange was going on with the viewport, but it seems that the original viewport that was
            // set when the game starts up, is lost after a draw to a render target
            // Just reset the viewport to the original
            BrainGame.Graphics.Viewport = BrainGame.Viewport;

            _screen.SpriteBatch.Begin(SpriteSortMode.Immediate, null, BrainGame.CurrentSampler, null, null, BrainGame.RenderEffect);
            _screen.SpriteBatch.Draw(_texture, this._drawRect, new Color(this._alpha, this._alpha, this._alpha, this._alpha));
            _screen.SpriteBatch.End();
        }


        /// <summary>
        /// Performs the blur in a single call
        /// Normaly the blur is made in more then 1 passage in Blur.Update(), making a blur over a blur
        /// This method will perform the same blur in a single call. It's used to restore the blur after the application got focus
        /// or the screen mode changes
        /// This method does not launch any events
        /// </summary>
        public virtual void PerformBlur()
        {
       //     this.Reset(); // Removed because this sets _texture to null!!
            for (int i = 0; i < this._iterations; i++)
            {
                _texture = this._blurEffect.Draw(_texture);
            }
            this.Ended = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void TransitionOut()
        {
            this._fadingOut = true;
            this._alpha = 1.0f;
        }
	}
}
