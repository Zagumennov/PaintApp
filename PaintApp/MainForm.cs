using MetroFramework.Forms;
using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class MainForm : MetroForm
    {
        enum Figures { Line, Quadrangle };

        float firstPointX = 0;
        float firstPointY = 0;

        float lastPointX = 0;
        float lastPointY = 0;

        bool isMouseDown = false;
        bool isMouseUp = false;

        bool isChangedOpenGLView = true;
        bool isLoadOpenGLView = false;

        float zoomOpenGLView = 1.0f;

        Figures selectedFigure = Figures.Line;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void preGL2D(OpenGL gl, int width, int height)
        {
            gl.DrawBuffer(OpenGL.GL_FRONT);
            gl.Viewport(0, 0, width, height);

            gl.MatrixMode(OpenGL.GL_PROJECTION);

            gl.LoadIdentity();

            gl.Ortho(0, width, 0, height, -1, 1);

            gl.MatrixMode(OpenGL.GL_MODELVIEW);

            gl.LoadIdentity();
            
            gl.ShadeModel(OpenGL.GL_SMOOTH);               // Enable Smooth Shading
            gl.PixelStore(OpenGL.GL_UNPACK_ALIGNMENT, 4);  //4-byte pixel alignment
            gl.Hint(OpenGL.GL_PERSPECTIVE_CORRECTION_HINT, OpenGL.GL_NICEST);

            gl.Enable(OpenGL.GL_DEPTH_TEST);
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            gl.Disable(OpenGL.GL_CULL_FACE);
            gl.Enable(OpenGL.GL_BLEND);

            gl.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);

            gl.Enable(OpenGL.GL_LINE_SMOOTH);

            gl.Hint(OpenGL.GL_LINE_SMOOTH_HINT, OpenGL.GL_NICEST);

            gl.ColorMaterial(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_AMBIENT_AND_DIFFUSE);
            gl.Enable(OpenGL.GL_COLOR_MATERIAL);

            gl.ClearColor(1, 1, 1, 1);
            gl.ClearStencil(0);
            gl.ClearDepth(1.0);

            gl.DepthFunc(OpenGL.GL_LEQUAL);

            gl.Clear(OpenGL.GL_DEPTH_BUFFER_BIT | OpenGL.GL_COLOR_BUFFER_BIT);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openGLControlView_Click(object sender, EventArgs e)
        {

        }

        private void openGLControlView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void openGLControlView_MouseDown(object sender, MouseEventArgs e)
        {
            firstPointX = e.X;
            firstPointY = e.Y;

            isMouseDown = true;
            isMouseUp = false;
            isChangedOpenGLView = true;
        }

        private void openGLControlView_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isLoadOpenGLView) return;
            if (!isLoadOpenGLView) return;

            if (isMouseDown)
            {
                lastPointX = e.X;
                lastPointY = e.Y;

                isChangedOpenGLView = true;
            }
        }


        private void openGLControlView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!isLoadOpenGLView) return;

            if (e.Delta < 0)
            {
                zoomOpenGLView *= 1.05f;
            }
            else
            {
                zoomOpenGLView *= 0.95f;
            }
            isChangedOpenGLView = true;
        }

        private void metroButtonRect_Click(object sender, EventArgs e)
        {
            selectedFigure = Figures.Quadrangle;
        }

        private void metroButtonLine_Click(object sender, EventArgs e)
        {
            selectedFigure = Figures.Line;
        }

        public void DrawQuadrangle(OpenGL gl, float firstPointX, float firstPointY, float lastPointX, float lastPointY)
        {
            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(0, 0, 0);
            gl.Vertex(firstPointX, firstPointY);

            gl.Color(0, 0, 0);
            gl.Vertex(firstPointX, lastPointY);
            
            gl.Color(0, 0, 0);
            gl.Vertex(lastPointX, lastPointY);
            
            gl.Color(0, 0, 0);
            gl.Vertex(lastPointX, firstPointY);
            gl.End();
        }

        public void DrawLine(OpenGL gl, float firstPointX, float firstPointY, float lastPointX, float lastPointY)
        {
            gl.Begin(OpenGL.GL_LINES);

            gl.Color(0, 0, 0);
            gl.Vertex(firstPointX, firstPointY);
            
            gl.Color(0, 0, 0);
            gl.Vertex(lastPointX, lastPointY);
            gl.End();
        }

        private void openGLControlView_OpenGLDraw(object sender, RenderEventArgs args)
        {
            if (!isLoadOpenGLView) return;
            if (isChangedOpenGLView)
            {
                OpenGL gl = openGLControlView.OpenGL;
                int contextWidth = openGLControlView.Width;
                int contextHeight = openGLControlView.Height;
                preGL2D(gl, openGLControlView.Width, openGLControlView.Height);

                switch (selectedFigure)
                {
                    case Figures.Quadrangle:
                        DrawQuadrangle(gl,
                            firstPointX,
                            openGLControlView.Height - firstPointY,
                            lastPointX,
                            openGLControlView.Height - lastPointY);
                        break;
                    case Figures.Line:
                        DrawLine(gl,
                            firstPointX,
                            openGLControlView.Height - firstPointY,
                            lastPointX,
                            openGLControlView.Height - lastPointY);
                        break;
                }

                gl.Flush();
                isChangedOpenGLView = false;
            }
        }

        

        private void openGLControlView_OpenGLInitialized(object sender, EventArgs e)
        {
            isLoadOpenGLView = true;
        }

        private void openGLControlView_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            isMouseUp = true;
        }

        private void openGLControlView_Load(object sender, EventArgs e)
        {
        }
    }
}
