//Window.h
#include <Window.h>

LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

class Window
{
public:
    Window();
    Window(const Window&) = delete;
    Window& operator = (const Window&) = delete;
    ~Window();

    bool ProccessMessages();
private:
    HINSTANCE m_hInstance;
	HWND m_hWnd;
};
