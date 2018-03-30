## Установка и запуск

`npm install babel webpack webpack-dev-server -g`
`npm install`

## Технологии

- https://github.com/babel/babel-loader

### ReactJs

При разработке и экспериментах удобно пользоваться возможностью исполнять/загружать jsx-скрипты в браузере (через тэг script). С 12.06.2015 розработчики react [отказались](https://facebook.github.io/react/blog/2015/06/12/deprecating-jstransform-and-react-tools.html) от использования JSTransform для этой цели и перешли на babel. Однако [13 ноября из babel-core был исключен browser.js](https://github.com/facebook/react/issues/5497) - скрипт, позволяющий компилировать в браузере. На момент написания данной заметки для компиляции jsx в браузере есть следующие варианты:

- использовать babel-core версии 5.8.3
- использовать [babel-standalone](https://github.com/Daniel15/babel-standalone)

Другой вариант - использовать webpack или browserify для компиляции после сохранения. Приме подобной настройки рабочей среды есть в [этом видео](https://egghead.io/lessons/react-react-fundamentals-development-environment-setup).

См. также:

- [Issue with "!" in the Directory Path #315](https://github.com/webpack/webpack-dev-server/issues/315)
- https://github.com/gaearon/babel-plugin-react-transform