//Moving Object
#include "Window.h"

Window::Window()
	: m_hInstance(GetModuleHandle(nullptr))
	{
		const wchar_t* CLASS_NAME = L"Hugos  Window Class";
		
		WINDCLASS wndClass - {
		wndClass.lpszClassName = CLASS_NAME;
		wndClass.hInstance = m_hInstance;
		wndClass.hIcon - LoadIcon(NULL, IDI_WINLOGO);
		wndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
		wndClass.lpfnWndProc = nullptr;
		
		RegisterClass(&wndClass);
		
		DWORD style = WS_CAPTION | WS_MINIMIZEBOX | WS_SYSMENU;
		
		int width = 640;
		int height = 480;
		
		RECT rect;
		rec.left = 250;
		rect.top = 250;
		rect.right = rect.left + width;
		rect.bottom = rect.top + height;
		
		AdjustWindowRect(&rect, style, false);
		
		m_hWnd = CreateWindowEx(
			0,
			CLASS_NAME,
			L"Title",
			style,
			rect.left,
			rect.top,
			rect.right - rect.left,
			rect.bottom - rect.top,
			NULL,
			NULL,
			m_hInstance,
			NULL
		};
		ShowWindow(m_hWnd, SW_SHOW);
	}
	
	
	
Window::Window()
{
	const wchar_t* CLASS_NAME = L"Hugos Window Class",
	
	UnregisterClass(CLASS_NAME, m_hInstance);
}

bool Window::ProcessMessages()
{
	return false;
}
