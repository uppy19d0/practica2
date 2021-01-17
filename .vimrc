set number
set mouse=a
set numberwidth=1
set clipboard=unnamed
syntax enable
set showcmd
set ruler
set cursorline
set encoding=utf-8
set showmatch
set sw=2
set relativenumber
set laststatus=2
set noshowmode


call plug#begin('~/.vim/plugged')

" THEME
Plug 'morhetz/gruvbox'
call plug#end()	
" IDE
Plug 'easymotion/vim-easymotion'
Plug 'scrooloose/nerdtree',{'on':'NERDTreeToggle'}
Plug 'christoomey/vim-tmux-navigator'

colorscheme gruvbox
let g:gruvbox_contast_dark = "hard"
let NERDTreeQuitOnOpen=1
let mapleader=" "

nmap <Leader>s <Plug>(easymotion-s2)
nmap <Leader>nt :NERDTreeFind<CR>
nmap <Leader>w :w<CR>
nmap <Leader>q :q<CR>
